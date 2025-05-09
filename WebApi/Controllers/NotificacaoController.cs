using Microsoft.AspNetCore.Mvc;
using BridgePattern.Abstracoes;
using BridgePattern.Interfaces;
using DecoratorPattern.Interfaces;
using DecoratorPattern.Notificadores;
using AdapterPattern.Legacy;
using AdapterPattern.Adapters;

namespace WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class NotificacaoController(INotificadorBridge notificador) : ControllerBase
{
    private readonly INotificadorBridge _notificador = notificador;

    // Adapter Pattern
    [HttpPost]
    public IActionResult EnviarMensagem([FromQuery] string para, [FromQuery] string mensagem)
    {
        var adapter = new EmailAdapter(new EmailLegacyService());
        adapter.Enviar(para, mensagem);
        return Ok("Mensagem enviada!");
    }

    // Bridge Pattern
    [HttpPost("{mensagem}")]
    public IActionResult Enviar(string mensagem)
    {
        var notificacao = new Notificacao(_notificador);
        notificacao.EnviarNotificacao(mensagem);
        return Ok($"Notificação enviada: {mensagem}");
    }

    // Decorator Pattern
    [HttpGet]
    public IActionResult Enviar()
    {
        INotificacao notificador = new NotificadorEmail();
        notificador = new NotificadorSms(notificador);
        notificador = new NotificadorPush(notificador);

        notificador.Enviar("Pedido recebido com sucesso!");

        return Ok("Notificações enviadas");
    }
}