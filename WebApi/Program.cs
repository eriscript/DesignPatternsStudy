using AdapterPattern.Adapters;
using AdapterPattern.Interfaces;
using AdapterPattern.Legacy;
using BridgePattern.Implementacoes;
using BridgePattern.Interfaces;
using Microsoft.Extensions.Caching.Memory;
using ProxyPattern.Logging;
using ProxyPattern.Services;

var builder = WebApplication.CreateBuilder(args);

#region AdapterPattern
// Para usar o legacy
builder.Services.AddSingleton<ServicoPagamentoLegacy>();
// Para usar o adapter
builder.Services.AddTransient<IPagamentoService, PagamentoAdapter>();
#endregion

#region BridgePattern
// Para usar Email
builder.Services.AddTransient<INotificadorBridge, EmailNotificador>();

// Para usar SMS
// builder.Services.AddTransient<INotificadorBridge, SmsNotificador>();
#endregion

#region ProxyPattern
builder.Services.AddHttpClient<ClimaService>();
builder.Services.AddMemoryCache();

// Para usar o proxy
builder.Services.AddScoped<IClimaService>(sp =>
{
    var realService = new ClimaService(sp.GetRequiredService<HttpClient>());
    var cache = sp.GetRequiredService<IMemoryCache>();
    return new ClimaServiceProxy(realService, new ConsoleLogger(), cache);
});
#endregion

builder.Services.AddOpenApi();

builder.Services.AddControllers();
var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.MapControllers();
app.Run();