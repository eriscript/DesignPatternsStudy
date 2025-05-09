using AdapterPattern.Interfaces;
using AdapterPattern.Legacy;

namespace AdapterPattern.Adapters;

public class EmailAdapter(EmailLegacyService emailService) : INotificador
{
    private readonly EmailLegacyService _emailService = emailService;

    public void Enviar(string destino, string mensagem)
    {
        _emailService.SendMail(destino, mensagem);
    }
}