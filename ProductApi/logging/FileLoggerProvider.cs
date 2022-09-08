using Microsoft.Extensions.Logging;

namespace ProductApi.logging
{
    public class FileLoggerProvider : ILoggerProvider
    {
        public ILogger CreateLogger(string categoryName)
        {
            return new FileLogger("log.txt");
        }

        public void Dispose()
        {

        }
    }
}
