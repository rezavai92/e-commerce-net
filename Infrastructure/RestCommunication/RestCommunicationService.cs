using Application.shared.Interfaces;
using Newtonsoft.Json;

namespace Infrastructure.RestCommunication
{

    public class RestCommunicationService : IRestCommunicationService
    {
        private IHttpClientFactory _httpClientFactory;
        

        public RestCommunicationService(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<string> PostAsync(Uri uri, HttpContent content, CancellationToken cancellationToken)
        {
            using (var httpClient = _httpClientFactory.CreateClient())
            {
                var httpResponse = await httpClient.PostAsync(uri, content, cancellationToken);

                if (httpResponse == null || !httpResponse.IsSuccessStatusCode)
                {
                    throw new InvalidOperationException();

                }

                return await (httpResponse).Content.ReadAsStringAsync();

            }
        }

        public async Task<T?> PostAsync<T>(Uri uri, HttpContent content, CancellationToken cancellationToken)
        {
            using (var httpClient = _httpClientFactory.CreateClient())
            {
                var httpResponse = await httpClient.PostAsync(uri, content, cancellationToken);

                if (httpResponse == null || !httpResponse.IsSuccessStatusCode)
                {
                    throw new InvalidOperationException();

                }

                return JsonConvert.DeserializeObject<T>(await (httpResponse).Content.ReadAsStringAsync());

            }
        }
        public async Task<string> GetAsync(Uri uri, CancellationToken cancellationToken)
        {
            using (var httpClient = _httpClientFactory.CreateClient())
            {
                var httpResponse = await httpClient.GetAsync(uri, cancellationToken);

                if (httpResponse == null || !httpResponse.IsSuccessStatusCode)
                {
                    throw new InvalidOperationException();

                }
                var stringifiedResponse = await (httpResponse).Content.ReadAsStringAsync();

                return stringifiedResponse;

            }
        }

        public async Task<T?> GetAsync<T>(Uri uri, CancellationToken cancellationToken)
        {

            using (var httpClient = _httpClientFactory.CreateClient())
            {
                var httpResponse = await httpClient.GetAsync(uri, cancellationToken);

                if (httpResponse == null || !httpResponse.IsSuccessStatusCode)
                {
                    throw new InvalidOperationException();

                }

                var msg = await (httpResponse).Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<T>(msg);

            }

        }

        public async Task<string> DeleteAsync(Uri uri, CancellationToken cancellationToken)
        {
            using (var httpClient = _httpClientFactory.CreateClient())
            {
                var stringifiedResponse = await (await httpClient.DeleteAsync(uri, cancellationToken)).Content.ReadAsStringAsync();

                return stringifiedResponse;

            }
        }

    }
}
