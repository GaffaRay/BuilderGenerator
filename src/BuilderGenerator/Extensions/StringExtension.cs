using System.Linq;

namespace BuilderGenerator.Extensions;

public static class StringExtension
{
    public static string Capitalize(this string str)
    {
        if (str.Length == 1)
        {
            return str.ToUpper();
        }

        return str.First().ToString().ToUpper() + str.Substring(1);
    }
}
