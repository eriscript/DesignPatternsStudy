namespace FlyweightPattern.Models;

public class DadosCompartilhados(string modelo, string cor, string fabricante)
{
    public string Modelo { get; } = modelo;
    public string Cor { get; } = cor;
    public string Fabricante { get; } = fabricante;

    public void Exibir(string placa, string localizacao)
    {
        Console.WriteLine($"Carro: {Modelo} {Cor} {Fabricante}, Placa: {placa}, Localização: {localizacao}");
    }
}