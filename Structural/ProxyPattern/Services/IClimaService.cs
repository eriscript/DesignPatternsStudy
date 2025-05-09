namespace ProxyPattern.Services;

public interface IClimaService
{
    Task<string> ObterPrevisaoAsync(string cidade);
}