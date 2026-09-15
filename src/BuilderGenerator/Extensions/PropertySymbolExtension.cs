using System.Linq;
using Microsoft.CodeAnalysis;

namespace BuilderGenerator.Extensions;

public static class PropertySymbolExtension
{
    public static bool IsObsolete(this IPropertySymbol propertySymbol)
    {
        return propertySymbol.GetAttributes().Any(a => a.AttributeClass?.Name is "Obsolete" or "ObsoleteAttribute");
    }

    public static bool HasAccessibleSetter(this IPropertySymbol propertySymbol, bool includeInternals)
    {
        return propertySymbol.SetMethod is not null
            && (propertySymbol.SetMethod.DeclaredAccessibility == Accessibility.Public
                || (includeInternals && propertySymbol.SetMethod.DeclaredAccessibility == Accessibility.Internal));
    }
}
