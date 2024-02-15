using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.shared.Interfaces
{
    public interface IRestCommunicationService
    {
        Task<string> PostAsync(Uri uri, HttpContent content, CancellationToken cancellationToken);
        Task<T?> PostAsync<T>(Uri uri, HttpContent content, CancellationToken cancellationToken);
        Task<T?> GetAsync<T>(Uri uri, CancellationToken cancellationToken);
        Task<string> GetAsync(Uri uri, CancellationToken cancellationToken);
        Task<string> DeleteAsync(Uri uri, CancellationToken cancellationToken);
        
           
    }
}
