using Microsoft.AspNetCore.Mvc;
using ProxyPattern.Services;

namespace WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class ClimaController(IClimaService climaService) : ControllerBase
{
    [HttpGet("{cidade}")]
    public async Task<IActionResult> Get(string cidade)
    {
        var previsao = await climaService.ObterPrevisaoAsync(cidade);
        return Ok(previsao);
    }
}