namespace AdapterPattern.Legacy;

public class EmailLegacyService
{
    public void SendMail(string to, string body)
    {
        Console.WriteLine($"[LEGACY EMAIL] Para: {to} - Mensagem: {body}");
    }
}