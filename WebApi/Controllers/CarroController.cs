using Microsoft.AspNetCore.Mvc;
using FlyweightPattern.Factory;

namespace WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class CarroController : ControllerBase
{
    private static readonly CarroFlyweightFactory _factory = new();

    [HttpPost]
    public IActionResult CriarCarros()
    {
        var carros = new[]
        {
            new { Modelo = "Logan", Cor = "Prata", Fabricante = "Renault", Placa = "ABC1234", Localizacao = "Pátio A" },
            new { Modelo = "Logan", Cor = "Prata", Fabricante = "Renault", Placa = "DEF5678", Localizacao = "Pátio B" },
            new { Modelo = "Onix", Cor = "Preto", Fabricante = "Chevrolet", Placa = "GHI9012", Localizacao = "Pátio C" },
            new { Modelo = "Onix", Cor = "Preto", Fabricante = "Chevrolet", Placa = "JKL3456", Localizacao = "Pátio D" }
        };

        foreach (var c in carros)
        {
            var flyweight = _factory.GetCarroFlyweight(c.Modelo, c.Cor, c.Fabricante);
            flyweight.Exibir(c.Placa, c.Localizacao);
        }

        return Ok($"Total de flyweights utilizados: {_factory.TotalFlyweights()}");
    }
}