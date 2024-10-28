using System;
using Serilog;

namespace KomoSwitch.Test
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            InitializeLogger();
            
            var interceptor = new EventListener();
            interceptor.Start();
            
            Console.ReadKey();
            
            interceptor.Stop();
            
            Console.ReadKey();

        }
        
        private static void InitializeLogger()
        {
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Debug()
                .WriteTo.Console()
                .CreateLogger();
        }
    }
}