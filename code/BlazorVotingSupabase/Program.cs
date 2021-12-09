using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using BlazorVotingSupabase;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

var url = builder.Configuration["SupabaseUrl"];
var key = builder.Configuration["SupabaseKey"];
await Supabase.Client.InitializeAsync(url, key);

builder.Services.AddSingleton(x=>Supabase.Client.Instance);

var container = builder.Build();
await container.RunAsync();
