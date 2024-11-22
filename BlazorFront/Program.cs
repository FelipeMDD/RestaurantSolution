using BlazorFront;
using BlazorFront.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

// Servi�o do OrderService
builder.Services.AddScoped<IOrderService, OrderService>();
// Servi�o do ProductService
builder.Services.AddScoped<IProductService, ProductService>();

await builder.Build().RunAsync();
