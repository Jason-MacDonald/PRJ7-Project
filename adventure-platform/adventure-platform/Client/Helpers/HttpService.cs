using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

/* ##### RESOURCES #####
    HttpClient: https://docs.microsoft.com/en-us/dotnet/api/system.net.http.httpclient?view=netcore-3.1
    JsonSerializerOptions: https://docs.microsoft.com/en-us/dotnet/api/system.text.json.jsonserializeroptions?view=netcore-3.1
*/

namespace adventureplatform.Client.Helpers
{
    public class HttpService : IHttpService
    {

        #region ##### HEAD #####
        
        private readonly HttpClient httpClient; // 
    
        private JsonSerializerOptions DefaultJsonSerializerOptions =>
            new JsonSerializerOptions() { PropertyNameCaseInsensitive = true }; 

        public HttpService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        #endregion

        #region ##### POST #####

        public async Task<HttpResponseWrapper<object>> Post<T>(string url, T data)
        {
            var dataJson = JsonSerializer.Serialize(data);
            var stringContent = new StringContent(dataJson, Encoding.UTF8, "application/json");
            var response = await httpClient.PostAsync(url, stringContent);
            return new HttpResponseWrapper<object>(null, response.IsSuccessStatusCode, response);
        }

        public async Task<HttpResponseWrapper<TResponse>> Post<T, TResponse>(string url, T data)
        {
            var dataJson = JsonSerializer.Serialize(data);
            var stringContent = new StringContent(dataJson, Encoding.UTF8, "application/json");
            var response = await httpClient.PostAsync(url, stringContent);

            if (response.IsSuccessStatusCode)
            {
                var deserializedResponse = await Deserialize<TResponse>(response, DefaultJsonSerializerOptions);
                return new HttpResponseWrapper<TResponse>(deserializedResponse, true, response);
            }
            else
            {
                return new HttpResponseWrapper<TResponse>(default, false, response);
            }
        }

        #endregion

        #region ##### GET #####

        public async Task<HttpResponseWrapper<T>> Get<T>(string url)
        {
            var HttpResponse = await httpClient.GetAsync(url);

            if (HttpResponse.IsSuccessStatusCode)
            {
                var response = await Deserialize<T>(HttpResponse, DefaultJsonSerializerOptions);
                return new HttpResponseWrapper<T>(response, true, HttpResponse);
            }
            else
            {
                return new HttpResponseWrapper<T>(default, false, HttpResponse);
            }
        }

        #endregion

        #region ##### PUT #####

        public async Task<HttpResponseWrapper<object>> Put<T>(string url, T data)
        {
            var dataJson = JsonSerializer.Serialize(data);
            var stringContent = new StringContent(dataJson, Encoding.UTF8, "application/json");
            var response = await httpClient.PutAsync(url, stringContent);
            return new HttpResponseWrapper<object>(null, response.IsSuccessStatusCode, response);
        }

        #endregion

        #region ##### DELETE #####

        public async Task<HttpResponseWrapper<object>> Delete(string url)
        {
            var httpResponse = await httpClient.DeleteAsync(url);
            return new HttpResponseWrapper<object>(null, httpResponse.IsSuccessStatusCode, httpResponse);
        }

        #endregion

        #region ##### DESERIALIZE #####

        private async Task<T> Deserialize<T>(HttpResponseMessage httpResponse, JsonSerializerOptions options)
        {
            var responseString = await httpResponse.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<T>(responseString, options);
        }

        #endregion

    }
}
