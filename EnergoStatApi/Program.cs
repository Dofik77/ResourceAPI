using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnergoStatApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            AppContext.SetSwitch("optionsBuilder.UseSqlServer(\"Server=(localdb)\\\\mssqllocaldb;Database=helloappdb;Trusted_Connection=True;\");", true);
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
