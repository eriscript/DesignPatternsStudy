using Microsoft.AspNetCore.Mvc;
using FacadePattern.Facades;

namespace WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class PedidoController : ControllerBase
{
    [HttpPost]
    public IActionResult Post()
    {
        var pedidoFacade = new PedidoFacade();
        pedidoFacade.RealizarPedido();

        return Ok("Pedido realizado com sucesso.");
    }
}