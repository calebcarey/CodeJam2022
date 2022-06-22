using Microsoft.Extensions.Hosting;
using System;

namespace CodeJam2022
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Host.CreateDefaultBuilder(args)
            .ConfigureWebHostDefaults(webBuilder => {
                webBuilder.UseStartup<Startup>();
            })
            .Build()
            .Run();
        }

    }
}
