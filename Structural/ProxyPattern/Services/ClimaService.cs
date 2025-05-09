namespace ProxyPattern.Services;

public class ClimaService(HttpClient httpClient) : IClimaService
{
    private readonly HttpClient _httpClient = httpClient;

    public async Task<string> ObterPrevisaoAsync(string cidade)
    {
        await Task.Delay(2000);
        return $"Previsão do tempo para {cidade}: 20°C, sol e poucas nuvens";
    }
}