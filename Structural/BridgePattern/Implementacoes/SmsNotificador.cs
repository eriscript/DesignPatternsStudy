using BridgePattern.Interfaces;

namespace BridgePattern.Implementacoes;

public class SmsNotificador : INotificadorBridge
{
    public void Enviar(string mensagem)
    {
        Console.WriteLine($"SMS enviado: {mensagem}");
    }
}