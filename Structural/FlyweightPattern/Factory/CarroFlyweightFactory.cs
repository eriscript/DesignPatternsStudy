using FlyweightPattern.Models;
using FlyweightPattern.Flyweights;

namespace FlyweightPattern.Factory;

public class CarroFlyweightFactory
{
    private readonly Dictionary<string, CarroFlyweight> _flyweights = [];

    public CarroFlyweight GetCarroFlyweight(string modelo, string cor, string fabricante)
    {
        var chave = $"{modelo}-{cor}-{fabricante}";
        if (!_flyweights.ContainsKey(chave))
        {
            var dados = new DadosCompartilhados(modelo, cor, fabricante);
            _flyweights[chave] = new CarroFlyweight(dados);
        }

        return _flyweights[chave];
    }

    public int TotalFlyweights() => _flyweights.Count;
}