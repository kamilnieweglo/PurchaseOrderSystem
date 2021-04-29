using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using AntiFraudSystem.Database;
using AntiFraudSystem.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AntiFraudSystem
{
    class Program
    { 
        static async Task Main(string[] args)
        {
            IConfiguration configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .Build();

            var serviceProvider = new ServiceCollection()
                .AddLogging()
                .AddSingleton<IRepositoryService, RepositoryService>()
                .AddSingleton<IAntifraudService, AntifraudService>()
                .BuildServiceProvider();
            
            Environment.SetEnvironmentVariable("SqlitePath", configuration.GetSection("AppSettings").GetSection("SqlitePath").Value);
           
            var antifraudService = serviceProvider.GetService<IAntifraudService>();

            Console.WriteLine($"Loading json data.");
            antifraudService.LoadData(File.ReadAllText($"InputData/Input.json"));
           
            Console.WriteLine("Start anti-fraud checker...");
            antifraudService.RunMonitor();
        
            Console.ReadKey();
        }
    }
}
