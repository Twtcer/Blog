using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Threading.Tasks;

namespace Meowv.Blog.Web
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var host = Host.CreateDefaultBuilder(args)
                           .ConfigureWebHostDefaults(webBuilder =>
                           {
                               webBuilder.UseStartup<Startup>();
                           }).ConfigureServices(services =>
                           {
                               services.AddRazorPages();
                               services.AddHttpClient("api", x =>
                               {
                                   x.BaseAddress = new Uri("https://localhost:5001");
                               });
                           });
            await host.Build().RunAsync();
        }
    }
}