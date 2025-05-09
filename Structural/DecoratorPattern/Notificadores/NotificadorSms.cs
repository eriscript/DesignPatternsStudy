using DecoratorPattern.Interfaces;

namespace DecoratorPattern.Notificadores;

public class NotificadorSms(INotificacao notificador) : NotificadorDecorator(notificador)
{
    public override void Enviar(string mensagem)
    {
        base.Enviar(mensagem);
        Console.WriteLine($"SMS enviado: {mensagem}");
    }
}