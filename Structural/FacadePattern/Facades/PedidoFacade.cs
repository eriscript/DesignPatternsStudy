using FacadePattern.Interfaces;
using FacadePattern.Services;

namespace FacadePattern.Facades;

public class PedidoFacade
{
    private readonly IPagamentoService _pagamentoService;
    private readonly INotificacaoService _notificacaoService;
    private readonly IPedidoValidator _pedidoValidator;

    public PedidoFacade()
    {
        _pagamentoService = new PagamentoService();
        _notificacaoService = new NotificacaoService();
        _pedidoValidator = new PedidoValidator();
    }

    public void RealizarPedido()
    {
        if (_pedidoValidator.ValidarPedido())
        {
            _pagamentoService.ProcessarPagamento();
            _notificacaoService.EnviarNotificacao("Seu pedido foi realizado com sucesso!");
        }
    }
}