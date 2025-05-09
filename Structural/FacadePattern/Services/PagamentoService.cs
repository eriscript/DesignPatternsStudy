using FacadePattern.Interfaces;

namespace FacadePattern.Services;

public class PagamentoService : IPagamentoService
{
    public void ProcessarPagamento()
    {
        Console.WriteLine("Pagamento processado.");
    }
}