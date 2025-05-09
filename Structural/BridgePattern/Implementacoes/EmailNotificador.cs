using BridgePattern.Interfaces;

namespace BridgePattern.Implementacoes;

public class EmailNotificador : INotificadorBridge
{
    public void Enviar(string mensagem)
    {
        Console.WriteLine($"Email enviado: {mensagem}");
    }
}