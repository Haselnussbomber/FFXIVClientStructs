using Microsoft.CodeAnalysis;

namespace InteropGenerator.Extensions;

internal static class IFieldSymbolExtensions {
    public static int SizeOf(this IFieldSymbol fieldSymbol, Compilation compilation) {
        // fixed array
        if (fieldSymbol.IsFixedSizeBuffer)
            return fieldSymbol.FixedSize;

        if (fieldSymbol.Type is INamedTypeSymbol namedSymbol) {
            // FixedSizeArray
            if (fieldSymbol.TryGetAttributeWithFullyQualifiedMetadataName(InteropTypeNames.FixedSizeArrayAttribute, out _) &&
                namedSymbol.IsGenericType &&
                namedSymbol.TypeArguments.Length == 1 &&
                namedSymbol.Name.Length > 14 &&
                int.TryParse(namedSymbol.Name[14..], out int count2)) {
                return namedSymbol.TypeArguments[0].SizeOf(compilation) * count2;
            }
        }

        return fieldSymbol.Type.SizeOf(compilation);
    }
}
