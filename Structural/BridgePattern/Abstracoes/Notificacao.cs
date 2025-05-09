using BridgePattern.Interfaces;

namespace BridgePattern.Abstracoes;

public class Notificacao(INotificadorBridge notificador)
{
    protected readonly INotificadorBridge _notificador = notificador;

    public virtual void EnviarNotificacao(string mensagem)
    {
        _notificador.Enviar(mensagem);
    }
}