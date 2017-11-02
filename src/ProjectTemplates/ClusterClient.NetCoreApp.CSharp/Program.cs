using Microsoft.Extensions.Logging;
using Orleans;
using Orleans.Runtime;
using Orleans.Runtime.Configuration;
using System;
using System.Threading.Tasks;

namespace Company.ClusterClient
{
    public class Program
    {
        static async Task<int> Main(string[] args)
        {
            try
            {
                using (var client = await StartClientWithRetries())
                {
                    await DoClientWork(client);

                    Console.ReadKey();
                }

                return 0;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);

                return 1;
            }
        }

        private static async Task<IClusterClient> StartClientWithRetries(int initializeAttemptsBeforeFailing = 5)
        {
            var attempt = 0;
            var client = default(IClusterClient);

            while (true)
            {
                try
                {
                    var config = ClientConfiguration.LocalhostSilo();

                    client = new ClientBuilder()
                        .UseConfiguration(config)
                        // TODO: Register the Assembly which contain the grain interfaces
                        //.AddApplicationPartsFromReferences(typeof(IGrain1).Assembly)
                        .ConfigureLogging(logging => logging.AddConsole())
                        .Build();

                    await client.Connect();

                    Console.WriteLine("Client successfully connected to silo host");
                    break;
                }
                catch (SiloUnavailableException)
                {
                    attempt++;

                    Console.WriteLine($"Attempt {attempt} of {initializeAttemptsBeforeFailing} failed to initialize the Orleans client.");

                    if (attempt > initializeAttemptsBeforeFailing)
                    {
                        throw;
                    }

                    await Task.Delay(TimeSpan.FromSeconds(4));
                }
            }

            return client;
        }

        private static async Task DoClientWork(IClusterClient client)
        {
            // Use client.GetGrain<T>(id) to get a grain reference, then invoke grain methods as normal async methods.
            //
            // Example:
            // var grain = client.GetGrain<IGrain1>(Guid.NewGuid());
        }
    }
}
