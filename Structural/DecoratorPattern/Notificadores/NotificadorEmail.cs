using DecoratorPattern.Interfaces;

namespace DecoratorPattern.Notificadores;

public class NotificadorEmail : INotificacao
{
    public void Enviar(string mensagem)
    {
        Console.WriteLine($"Email enviado: {mensagem}");
    }
}