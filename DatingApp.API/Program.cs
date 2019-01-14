using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace DatingApp.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var dt = DateTime.Now.AddHours(-4);
            var test = DateTime.Now.ToShortTimeString() + ' ' +  DateTime.Now.ToString("tt", CultureInfo.InvariantCulture);
            Console.Write(test);
            var test2 = dt.ToString("hh:mm tt", CultureInfo.InvariantCulture);
            Console.Write(test2);
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
