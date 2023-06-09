using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

using Autofac.Extensions.DependencyInjection;
using XperienceAdapter.Logging;

namespace MedioClinic
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
             Host.CreateDefaultBuilder(args)
                .ConfigureLogging(logging => logging.AddXperience())
                .UseServiceProviderFactory(new AutofacServiceProviderFactory())
                
                .ConfigureWebHostDefaults(webBuilder =>
                {

                    webBuilder.CaptureStartupErrors(true);
                   
                    webBuilder.UseStartup<Startup>();
                });

    }
}
