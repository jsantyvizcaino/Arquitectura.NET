using Microsoft.Extensions.Configuration;
using Serilog;
using Serilog.Exceptions;
using ILogger = Serilog.ILogger;


namespace Shared.Common
{
    public static class LoggerCreator
    {
        public static ILogger CreateSerilogLogger(IConfiguration? configuration, string appName)
        {
            var loggerConfiguration = new LoggerConfiguration()
                .MinimumLevel.Verbose()
                .Enrich.WithProperty("ApplicationContext", appName)
                .Enrich.FromLogContext()
                .Enrich.WithExceptionDetails()
                .WriteTo.Console();

            return loggerConfiguration.ReadFrom.Configuration(configuration).CreateLogger();
        }
    }
}
