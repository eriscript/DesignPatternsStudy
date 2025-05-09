using FlyweightPattern.Models;

namespace FlyweightPattern.Flyweights;

public class CarroFlyweight(DadosCompartilhados dadosCompartilhados)
{
    private readonly DadosCompartilhados _dadosCompartilhados = dadosCompartilhados;

    public void Exibir(string placa, string localizacao)
    {
        _dadosCompartilhados.Exibir(placa, localizacao);
    }
}