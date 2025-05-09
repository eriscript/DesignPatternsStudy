using CompositePattern.Interfaces;

namespace CompositePattern.Models;

public class Arquivo(string nome) : IArquivo
{
    public string Nome { get; } = nome;

    public void Exibir(string indentacao = "")
    {
        Console.WriteLine($"{indentacao}- {Nome}");
    }
}