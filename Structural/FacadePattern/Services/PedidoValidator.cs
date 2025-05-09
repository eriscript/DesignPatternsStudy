using FacadePattern.Interfaces;

namespace FacadePattern.Services;

public class PedidoValidator : IPedidoValidator
{
    public bool ValidarPedido()
    {
        Console.WriteLine("Pedido validado.");
        return true;
    }
}