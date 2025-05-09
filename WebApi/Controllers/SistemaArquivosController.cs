using Microsoft.AspNetCore.Mvc;
using CompositePattern.Models;

namespace WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class SistemaArquivosController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        var raiz = new Diretorio("Raiz");

        var arquivo1 = new Arquivo("arquivo1.txt");
        var arquivo2 = new Arquivo("arquivo2.txt");

        var subdir = new Diretorio("Subdiretorio");
        subdir.Adicionar(new Arquivo("sub_arquivo1.txt"));

        raiz.Adicionar(arquivo1);
        raiz.Adicionar(subdir);
        raiz.Adicionar(arquivo2);

        raiz.Exibir();

        return Ok("Sistema de arquivos exibido no console.");
    }
}