using System;
using System.Threading.Tasks;
using Grpc.Net.Client;
using MurphyCooper.Common;
using static MurphyCooper.Common.Test;

namespace MurphyCooper.GrpcClient
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var channel = GrpcChannel.ForAddress("http://localhost:5000", new GrpcChannelOptions()
            {
            });

            var client = new TestClient(channel);

            while (true)
            {
                await Task.Delay(1000);
                var response = await client.HelloAsync(new TestRequest()
                {
                    Name = "Murphy"
                });

                Console.WriteLine(response);
            }

        }
    }
}
