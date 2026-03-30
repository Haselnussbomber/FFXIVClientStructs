// partially sourced from https://github.com/Sergio0694/ComputeSharp/blob/main/src/ComputeSharp.SourceGeneration/Extensions/ITypeSymbolExtensions.cs

using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using InteropGenerator.Helpers;
using Microsoft.CodeAnalysis;

namespace InteropGenerator.Extensions;

/// <summary>
///     Extension methods for <see cref="ITypeSymbol" /> types.
/// </summary>
// ReSharper disable once InconsistentNaming
internal static class ITypeSymbolExtensions {
    /// <summary>
    ///     Checks whether or not a given type symbol has a specified fully qualified metadata name.
    /// </summary>
    /// <param name="symbol">The input <see cref="ITypeSymbol" /> instance to check.</param>
    /// <param name="name">The full name to check.</param>
    /// <returns>Whether <paramref name="symbol" /> has a full name equals to <paramref name="name" />.</returns>
    public static bool HasFullyQualifiedMetadataName(this ITypeSymbol symbol, string name) {
        using ImmutableArrayBuilder<char> builder = new();

        symbol.AppendFullyQualifiedMetadataName(in builder);

        return builder.WrittenSpan.SequenceEqual(name.AsSpan());
    }

    /// <summary>
    ///     Gets the fully qualified metadata name for a given <see cref="ITypeSymbol" /> instance.
    /// </summary>
    /// <param name="symbol">The input <see cref="ITypeSymbol" /> instance.</param>
    /// <returns>The fully qualified metadata name for <paramref name="symbol" />.</returns>
    public static string GetFullyQualifiedMetadataName(this ITypeSymbol symbol) {
        using ImmutableArrayBuilder<char> builder = new();

        symbol.AppendFullyQualifiedMetadataName(in builder);

        return builder.ToString();
    }

    /// <summary>
    ///     Appends the fully qualified metadata name for a given symbol to a target builder.
    /// </summary>
    /// <param name="symbol">The input <see cref="ITypeSymbol" /> instance.</param>
    /// <param name="builder">The target <see cref="ImmutableArrayBuilder{T}" /> instance.</param>
    public static void AppendFullyQualifiedMetadataName(this ITypeSymbol symbol, ref readonly ImmutableArrayBuilder<char> builder) {
        static void BuildFrom(ISymbol? symbol, ref readonly ImmutableArrayBuilder<char> builder) {
            switch (symbol) {
                // Namespaces that are nested also append a leading '.'
                case INamespaceSymbol { ContainingNamespace.IsGlobalNamespace: false }:
                    BuildFrom(symbol.ContainingNamespace, in builder);
                    builder.Add('.');
                    builder.AddRange(symbol.MetadataName.AsSpan());
                    break;

                // Other namespaces (ie. the one right before global) skip the leading '.'
                case INamespaceSymbol { IsGlobalNamespace: false }:
                    builder.AddRange(symbol.MetadataName.AsSpan());
                    break;

                // Types with no namespace just have their metadata name directly written
                case ITypeSymbol { ContainingSymbol: INamespaceSymbol { IsGlobalNamespace: true } }:
                    builder.AddRange(symbol.MetadataName.AsSpan());
                    break;

                // Types with a containing non-global namespace also append a leading '.'
                case ITypeSymbol { ContainingSymbol: INamespaceSymbol namespaceSymbol }:
                    BuildFrom(namespaceSymbol, in builder);
                    builder.Add('.');
                    builder.AddRange(symbol.MetadataName.AsSpan());
                    break;

                // Nested types append a leading '+'
                case ITypeSymbol { ContainingSymbol: ITypeSymbol typeSymbol }:
                    BuildFrom(typeSymbol, in builder);
                    builder.Add('+');
                    builder.AddRange(symbol.MetadataName.AsSpan());
                    break;
            }
        }

        BuildFrom(symbol, in builder);
    }

    public static int SizeOf(this ITypeSymbol symbol, Compilation compilation) {
        int pointerSize = compilation.Options.Platform switch {
            Platform.X86 => 4,
            Platform.AnyCpu32BitPreferred => 4,
            _ => 8
        };

        switch (symbol.SpecialType) {
            case SpecialType.System_Boolean:
            case SpecialType.System_SByte:
            case SpecialType.System_Byte:
                return 1;
            case SpecialType.System_Char:
            case SpecialType.System_Int16:
            case SpecialType.System_UInt16:
                return 2;
            case SpecialType.System_Int32:
            case SpecialType.System_UInt32:
            case SpecialType.System_Single:
                return 4;
            case SpecialType.System_Int64:
            case SpecialType.System_UInt64:
            case SpecialType.System_Double:
                return 8;
            case SpecialType.System_IntPtr:
            case SpecialType.System_UIntPtr:
                return pointerSize;
        }

        if (symbol.TypeKind is TypeKind.Pointer or TypeKind.FunctionPointer) {
            return pointerSize;
        }

        if (symbol.TypeKind is TypeKind.Enum && symbol is INamedTypeSymbol enumType) {
            return enumType.EnumUnderlyingType?.SizeOf(compilation) ?? 0;
        }

        string fqn = symbol.GetFullyQualifiedName()["global::".Length..];
        switch (fqn) {
            case InteropTypeNames.CStringPointer:
                return pointerSize;

            case "System.Half":
                return sizeof(ushort);

            case "System.Drawing.Point":
                return Unsafe.SizeOf<System.Drawing.Point>();

            case "System.Numerics.Vector2":
                return Unsafe.SizeOf<System.Numerics.Vector2>();

            case "System.Numerics.Vector3":
                return Unsafe.SizeOf<System.Numerics.Vector3>();

            case "System.Numerics.Vector4":
                return Unsafe.SizeOf<System.Numerics.Vector4>();

            case "System.Numerics.Pane":
                return Unsafe.SizeOf<System.Numerics.Plane>();

            case "System.Numerics.Quaternion":
                return Unsafe.SizeOf<System.Numerics.Quaternion>();

            case "System.Numerics.Matrix3x2":
                return Unsafe.SizeOf<System.Numerics.Matrix3x2>();

            case "System.Numerics.Matrix4x4":
                return Unsafe.SizeOf<System.Numerics.Matrix4x4>();
        }

        if (symbol is INamedTypeSymbol namedType) {
            // InlineArray
            if (namedType.TryGetAttributeWithFullyQualifiedMetadataName("System.Runtime.CompilerServices.InlineArrayAttribute", out AttributeData? inlineArrayAttributeData) &&
                inlineArrayAttributeData.TryGetConstructorArgument(0, out int length)) {
                return namedType.TypeArguments[0].SizeOf(compilation) * length;
            }

            // Structs
            if (namedType.TypeKind == TypeKind.Struct) {
                int pack = 0;
                int size = 0;
                LayoutKind kind = LayoutKind.Sequential; // default

                var attrs = namedType.GetAttributes();

                if (namedType.TryGetAttributeWithFullyQualifiedMetadataName("System.Runtime.InteropServices.StructLayoutAttribute", out AttributeData? layoutData)) {
                    if (layoutData.ConstructorArguments.Length >= 1 && !layoutData.ConstructorArguments[0].IsNull) {
                        kind = (LayoutKind)layoutData.ConstructorArguments[0].Value!;
                    }

                    layoutData.TryGetNamedArgument("Pack", out pack);
                    layoutData.TryGetNamedArgument("Size", out size);
                }

                if (kind == LayoutKind.Explicit) {
                    return size;
                }

                if (kind == LayoutKind.Sequential) {
                    int offset = 0;
                    int alignment = 1;

                    foreach (var field in namedType.GetMembers().OfType<IFieldSymbol>()) {
                        if (field.IsStatic || !field.Locations.Any(loc => loc.IsInSource))
                            continue;

                        int fieldSize = field.SizeOf(compilation);
                        if (fieldSize <= 0)
                            return 0;

                        int fieldAlignment = fieldSize;
                        if (pack > 0)
                            fieldAlignment = Math.Min(pack, fieldAlignment);

                        offset = (offset + fieldAlignment - 1) / fieldAlignment * fieldAlignment;
                        offset += fieldSize;

                        alignment = Math.Max(alignment, fieldAlignment);
                    }

                    return (offset + alignment - 1) / alignment * alignment;
                }
            }
        }

        return 0;
    }
}
