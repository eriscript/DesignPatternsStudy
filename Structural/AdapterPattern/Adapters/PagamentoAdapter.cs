using AdapterPattern.Interfaces;
using AdapterPattern.Legacy;

namespace AdapterPattern.Adapters;

public class PagamentoAdapter(ServicoPagamentoLegacy servicoLegacy) : IPagamentoService
{
    private readonly ServicoPagamentoLegacy _servicoLegacy = servicoLegacy;

    public void EfetuarPagamento(decimal valor)
    {
        _servicoLegacy.Pagar(valor.ToString("F2"));
    }
}