using Application.shared.Interfaces;
using Microsoft.Extensions.Logging;

namespace Infrastructure.Logging
{
    public class PlatformLoggerService<T> : IPlatformLogger<T> where T : class
    {
        ILogger<T> _logger;

        public PlatformLoggerService(ILogger<T> logger)
        {
            _logger = logger;
        }

        public void LogInformation(string message)
        {
            _logger.LogInformation(message);
        }

        public void LogError(string message)
        {
            _logger.LogError(message);
        }
        public void LogDebug(string message)
        {
            _logger.LogDebug(message);

        }
        public void LogWarning(string message)
        {
            _logger.LogWarning(message);
        }
        public void LogCritical(string message)
        {
            _logger.LogCritical(message);
        }
    }
}
