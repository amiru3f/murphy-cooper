using System.Net;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Server.Kestrel.Core;
using Microsoft.Extensions.Hosting;

namespace MurphyCooper
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder
                   .ConfigureKestrel((context, serverOptions) =>
                    {
                        //for rest
                        serverOptions.Listen(IPAddress.Loopback, 5001, listenOptions =>
                        {
                            listenOptions.Protocols = HttpProtocols.Http1AndHttp2;
                        });

                        //for grpc
                        serverOptions.Listen(IPAddress.Loopback, 5000, listenOptions =>
                        {
                            listenOptions.Protocols = HttpProtocols.Http2;
                        });
                    })
                    .UseStartup<Startup>();
                });
    }
}