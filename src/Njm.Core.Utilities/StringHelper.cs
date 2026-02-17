namespace Njm.Core.Utilities;

public static class StringHelper
{
    public static bool IsNullOrEmpty(string? value)
        => string.IsNullOrEmpty(value);

    public static string ToTitleCase(string input)
        => System.Globalization.CultureInfo
            .CurrentCulture
            .TextInfo
            .ToTitleCase(input.ToLower());

    // ✅ NEW METHOD
    public static string Truncate(string value, int maxLength)
    {
        if (string.IsNullOrEmpty(value))
            return value;

        return value.Length <= maxLength 
            ? value 
            : value.Substring(0, maxLength) + "...";
    }

    // ✅ NEW METHOD
    public static string GenerateGuid()
        => Guid.NewGuid().ToString();
}
