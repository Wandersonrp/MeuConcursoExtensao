using Blazor.BrowserExtension;
using MeuConcurso.WebAssembly;
using MeuConcurso.WebAssembly.Services.Layout;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.UseBrowserExtension(browserExtension =>
{
    if (browserExtension.Mode == BrowserExtensionMode.Background)
    {
        builder.RootComponents.AddBackgroundWorker<BackgroundWorker>();
    }
    else
    {
        builder.RootComponents.Add<App>("#app");
        builder.RootComponents.Add<HeadOutlet>("head::after");
    }
});

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddScoped<LayoutStateService>();

builder.Services.AddMudServices();

await builder.Build().RunAsync();
