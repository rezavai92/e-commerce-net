using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.shared.Interfaces
{
    public interface IPlatformLogger <T> where T : class
    {
        public void LogInformation(string message);


        public void LogError(string message);

        public void LogDebug(string message);

        public void LogWarning(string message);

        public void LogCritical(string message);
        
    }
}
