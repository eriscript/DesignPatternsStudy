using Microsoft.AspNetCore.Mvc;
using AdapterPattern.Interfaces;

namespace WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class PagamentoController(IPagamentoService pagamentoService) : ControllerBase
{
    private readonly IPagamentoService _pagamentoService = pagamentoService;

    [HttpPost("{valor}")]
    public IActionResult EfetuarPagamento(decimal valor)
    {
        _pagamentoService.EfetuarPagamento(valor);
        return Ok($"Pagamento de R$ {valor} efetuado com sucesso.");
    }
}
