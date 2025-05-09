using Microsoft.Extensions.Caching.Memory;
using ProxyPattern.Logging;

namespace ProxyPattern.Services;

public class ClimaServiceProxy(IClimaService climaService, ILogger logger, IMemoryCache cache) : IClimaService
{
    public async Task<string> ObterPrevisaoAsync(string cidade)
    {
        var chaveCache = $"previsao_{cidade}";
        if (cache.TryGetValue(chaveCache, out string? previsao))
        {
            logger.Log($"Cache HIT para: {cidade}");
            return previsao;
        }

        logger.Log($"Cache MISS para: {cidade}, chamando serviço real...");
        previsao = await climaService.ObterPrevisaoAsync(cidade);
        cache.Set(chaveCache, previsao, TimeSpan.FromMinutes(10));
        return previsao;
    }
}