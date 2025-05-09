using CompositePattern.Interfaces;

namespace CompositePattern.Models;

public class Diretorio(string nome) : IArquivo
{
    public string Nome { get; } = nome;
    private readonly List<IArquivo> _itens = [];

    public void Adicionar(IArquivo item)
    {
        _itens.Add(item);
    }

    public void Exibir(string indentacao = "")
    {
        Console.WriteLine($"{indentacao}+ {Nome}");
        foreach (var item in _itens)
        {
            item.Exibir(indentacao + "  ");
        }
    }
}