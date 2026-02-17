namespace Njm.Core.Diagnostics;

public static class LoggerService
{
    public static void LogInfo(string message)
        => Console.WriteLine($"[INFO] {DateTime.Now}: {message}");
}
