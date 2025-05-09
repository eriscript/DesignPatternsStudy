using DecoratorPattern.Interfaces;

namespace DecoratorPattern.Notificadores;

public abstract class NotificadorDecorator(INotificacao notificador) : INotificacao
{
    protected readonly INotificacao _notificador = notificador;

    public virtual void Enviar(string mensagem)
    {
        _notificador.Enviar(mensagem);
    }
}