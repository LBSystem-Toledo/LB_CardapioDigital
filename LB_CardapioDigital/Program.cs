using LB_CardapioDigital;
using LB_CardapioDigital.Services;
using LB_CardapioDigital.Services.Interfaces;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Radzen;

#if DEBUG
    string url = "https://localhost:5011";
#else 
    string url = "";
#endif

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(url) });

builder.Services.AddScoped<IGrupoService, GrupoService>();
builder.Services.AddScoped<IAdicionalService, AdicionalService>();

builder.Services.AddScoped<ContextMenuService>();
builder.Services.AddScoped<DialogService>();
builder.Services.AddScoped<NotificationService>();

await builder.Build().RunAsync();
