using Microsoft.Extensions.Logging;
using System;
using System.IO;

namespace ProductApi.logging
{
    public class FileLogger : ILogger
    {
        string filename;
        private object locker = new object();

        public FileLogger(string filename)
        {
            this.filename = filename;
        }

        public IDisposable BeginScope<TState>(TState state)
        {
            return null;
        }

        public bool IsEnabled(LogLevel logLevel)
        {
            return true;
        }

        public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception exception, Func<TState, Exception, string> formatter)
        {
            lock (locker)
            {
                File.AppendAllText(filename, $"{logLevel}: {DateTime.Now} - {state}\n");
            }
        }
    }
}
