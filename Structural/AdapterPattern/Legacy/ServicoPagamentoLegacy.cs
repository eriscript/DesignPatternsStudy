namespace AdapterPattern.Legacy;

public class ServicoPagamentoLegacy
{
    public void Pagar(string valor)
    {
        Console.WriteLine($"[LEGACY] Pagamento realizado no valor de R$ {valor}");
    }
}