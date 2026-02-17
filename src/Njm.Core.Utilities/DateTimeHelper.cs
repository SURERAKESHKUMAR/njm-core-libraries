namespace Njm.Core.Utilities;

public static class DateTimeHelper
{
    public static string ToIndianFormat(DateTime date)
        => date.ToString("dd/MM/yyyy");
}
