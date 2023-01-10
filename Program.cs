using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace ModelBinder
{
    public class Program
    {
        static void Main(string[] args)
        {
            MyBuilder(args).Build().Run();
            //Console.WriteLine("Hello, World!");
        }
        public static IHostBuilder MyBuilder(string[] args)
        {
            return Host.CreateDefaultBuilder(args).ConfigureWebHostDefaults(webHost => { webHost.UseStartup<Startup>(); });
        }
    }
}