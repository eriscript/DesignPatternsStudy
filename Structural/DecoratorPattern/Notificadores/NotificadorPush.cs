using DecoratorPattern.Interfaces;

namespace DecoratorPattern.Notificadores;

public class NotificadorPush(INotificacao notificador) : NotificadorDecorator(notificador)
{
    public override void Enviar(string mensagem)
    {
        base.Enviar(mensagem);
        Console.WriteLine($"Push Notification enviada: {mensagem}");
    }
}