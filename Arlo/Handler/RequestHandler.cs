using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using Arlo.Models;

namespace Arlo.Handler
{
    public class RequestHandler
    {
        private HttpClient _httpClient;
        public RequestHandler()
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri("https://my.arlo.com/");
        }

        public string Authorization
        {
            get
            {
                return _httpClient.DefaultRequestHeaders.Authorization.Parameter;
            }
            set
            {
                _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("", value);
            }
        }

        public async Task<Result<T>> GetAsync<T>(string uri)
        {
            return await MakeRequestAsync<T>(HttpMethod.Get, uri, null);
        }

        public async Task<Result<T>> PostAsync<T>(string uri, object parameter = null)
        {
            return await MakeRequestAsync<T>(HttpMethod.Post, uri, parameter);
        }

        public async Task<Result<T>> PutAsync<T>(string uri, object parameter = null)
        {
            return await MakeRequestAsync<T>(HttpMethod.Put, uri, parameter);
        }

        private async Task<Result<T>> MakeRequestAsync<T>(HttpMethod httpMethod, string uri, object parameter)
        {
            try
            {
                var request = new HttpRequestMessage(httpMethod, uri);

                request.Headers.Add("Accept", "application/json");
                request.Headers.Add("User-Agent", "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_15_0) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/75.0.3770.142 Safari/537.36");

                switch (httpMethod.Method)
                {
                    case "GET":
                        break;
                    case "PUT":
                    case "POST":
                        if (parameter != null)
                        {
                            string json = JsonSerializer.Serialize(parameter);
                            System.Diagnostics.Debug.WriteLine(json);
                            request.Content = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
                        }
                        break;
                }

                var response = await _httpClient.SendAsync(request);

                if (response.IsSuccessStatusCode)
                {
                    using (var responseStream = await response.Content.ReadAsStreamAsync())
                    {
                        var obj = await JsonSerializer.DeserializeAsync<Result<T>>(responseStream);
                        return obj;
                    }
                }
                else
                {
                    var responseString = await response.Content.ReadAsStringAsync();
                    System.Diagnostics.Debug.WriteLine(responseString);

                    var errorObject = JsonSerializer.Deserialize<Result<ErrorData>>(responseString);

                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex);
            }

            return null;
        }
    }
}
