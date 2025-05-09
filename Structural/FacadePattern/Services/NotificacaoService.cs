using FacadePattern.Interfaces;

namespace FacadePattern.Services;

public class NotificacaoService : INotificacaoService
{
    public void EnviarNotificacao(string mensagem)
    {
        Console.WriteLine($"Notificação enviada: {mensagem}");
    }
}