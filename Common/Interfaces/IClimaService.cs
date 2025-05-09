namespace Common.Interfaces;

public interface IClimaService
{
	Task<string> ObterPrevisaoAsync(string cidade);
}