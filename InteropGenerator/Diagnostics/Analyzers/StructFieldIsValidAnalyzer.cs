using System.Collections.Immutable;
using System.Runtime.InteropServices;
using InteropGenerator.Extensions;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Diagnostics;
using static InteropGenerator.Diagnostics.DiagnosticDescriptors;

namespace InteropGenerator.Diagnostics.Analyzers;

[DiagnosticAnalyzer(LanguageNames.CSharp)]
public sealed class StructFieldIsValidAnalyzer : DiagnosticAnalyzer {

    public override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics { get; } = [
        StructFieldOffsetOutOfBounds,
        StructFieldOutOfBounds,
        // StructFieldOverlap,
    ];

    public override void Initialize(AnalysisContext context) {
        context.ConfigureGeneratedCodeAnalysis(GeneratedCodeAnalysisFlags.None);
        context.EnableConcurrentExecution();

        context.RegisterCompilationStartAction(static context => {
            if (context.Compilation.GetTypeByMetadataName("System.Runtime.InteropServices.StructLayoutAttribute") is not { } structLayoutAttribute)
                return;

            context.RegisterSymbolAction(context => {
                if (context.Symbol is not INamedTypeSymbol { TypeKind: TypeKind.Struct } structSymbol)
                    return;

                if (!structSymbol.TryGetAttributeWithType(structLayoutAttribute, out AttributeData? structLayoutAttributeData))
                    return;

                if (structLayoutAttributeData.ConstructorArguments.Length >= 1 &&
                    !structLayoutAttributeData.ConstructorArguments[0].IsNull &&
                    (LayoutKind)structLayoutAttributeData.ConstructorArguments[0].Value! != LayoutKind.Explicit) {
                    return;
                }

                if (!structLayoutAttributeData.TryGetNamedArgument("Size", out int structSize))
                    return;

                foreach (var fieldSymbol in structSymbol.GetMembers().OfType<IFieldSymbol>()) {
                    if (!fieldSymbol.TryGetAttributeWithFullyQualifiedMetadataName("System.Runtime.InteropServices.FieldOffsetAttribute", out var fieldOffsetAttribute))
                        continue;

                    if (!fieldOffsetAttribute.TryGetConstructorArgument(0, out int fieldOffset))
                        continue;

                    if (fieldOffset >= structSize) {
                        context.ReportDiagnostic(Diagnostic.Create(
                            StructFieldOffsetOutOfBounds,
                            fieldSymbol.Locations.FirstOrDefault(),
                            fieldSymbol.Name,
                            structSymbol.Name));
                        return;
                    }

                    int fieldSize = fieldSymbol.SizeOf(context.Compilation);
                    if (fieldSize == 0)
                        continue;

                    if (fieldOffset + fieldSize > structSize) {
                        context.ReportDiagnostic(Diagnostic.Create(
                            StructFieldOutOfBounds,
                            fieldSymbol.Locations.FirstOrDefault(),
                            fieldSymbol.Name,
                            structSymbol.Name));
                        return;
                    }

                    // Overlap check disabled because there is currently no way to define unions or ignore fields.
                    /*
                    foreach (var otherFieldSymbol in structSymbol.GetMembers().OfType<IFieldSymbol>()) {
                        if (SymbolEqualityComparer.Default.Equals(fieldSymbol, otherFieldSymbol))
                            continue;

                        if (!otherFieldSymbol.TryGetAttributeWithFullyQualifiedMetadataName("System.Runtime.InteropServices.FieldOffsetAttribute", out var otherFieldOffsetAttribute))
                            continue;

                        if (!otherFieldOffsetAttribute.TryGetConstructorArgument(0, out int otherFieldOffset))
                            continue;

                        int otherFieldSize = otherFieldSymbol.SizeOf(context.Compilation);
                        if (otherFieldSize == 0)
                            continue;

                        if (fieldOffset < (otherFieldOffset + otherFieldSize) && otherFieldOffset < (fieldOffset + fieldSize)) {
                            context.ReportDiagnostic(Diagnostic.Create(
                                StructFieldOverlap,
                                fieldSymbol.Locations.FirstOrDefault(),
                                fieldSymbol.Name,
                                structSymbol.Name));
                            return;
                        }
                    }
                    */
                }
            },
                SymbolKind.NamedType);
        });
    }
}
