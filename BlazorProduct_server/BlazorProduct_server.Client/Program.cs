using BlazorProduct_Application;
using BlazorProduct_Database;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

//builder.Services.AddDatabasse(builder.Configuration);
//builder.Services.AddApplication();
await builder.Build().RunAsync();
