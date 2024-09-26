using BlazorTinyBlog.Shared.Services;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

/*
 * Hacemos uso del contenedor de inyección de dependencias para poder
 * realizar solicitudes HTTP con HttpClient, lo utilizamos para interactuar con APIs
 * desde el navegador.
 */
builder.Services.AddScoped(sp => new HttpClient 
{
    BaseAddress = new Uri(builder.HostEnvironment.BaseAddress),
});

builder.Services.AddScoped<IBlogPostService, ClientBlogPostService>();

await builder.Build().RunAsync();
