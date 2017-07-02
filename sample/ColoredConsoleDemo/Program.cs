using Serilog;
using System;
using System.Threading;

namespace ColoredConsoleDemo
{
    public class Program
    {
        public static void Main()
        {
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Verbose()
                .WriteTo.ColoredConsole()
                .CreateLogger();

            try
            {
                Log.Verbose("Warming up");

                Log.Debug("Getting started");

                Log.Information("Hello {Name} from thread {ThreadId}", Environment.GetEnvironmentVariable("USERNAME"), Thread.CurrentThread.ManagedThreadId);

                Log.Warning("No coins remain at position {@Position}", new { Lat = 25, Long = 134 });

                Fail();
            }
            catch (Exception e)
            {
                Log.Error(e, "Something went wrong");
            }

            Log.CloseAndFlush();
        }

        static void Fail()
        {
            throw new DivideByZeroException();
        }
    }
}
