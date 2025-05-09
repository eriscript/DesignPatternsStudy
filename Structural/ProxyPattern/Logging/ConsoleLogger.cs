namespace ProxyPattern.Logging;

public class ConsoleLogger : ILogger
{
    public void Log(string mensagem)
    {
        Console.WriteLine($"[LOG] {DateTime.Now:HH:mm:ss} - {mensagem}");
    }
}