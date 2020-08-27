using adventureplatform.Shared.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace adventureplatform.Client.Helpers
{
    public static class IHttpServiceExtensionMethods
    {
        public static async Task<T> GetHelper<T>(this IHttpService httpService, string url)
        {
            var response = await httpService.Get<T>(url);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;
        }

        public static async Task<PaginatedResponse<T>> GetHelper<T>(this IHttpService httpService, string url, PaginationDTO paginationDTO)
        {
            string newURL;

            if (url.Contains("?"))
            {
                // Append to existing query string.
                newURL = $"{url}&page={paginationDTO.Page}&numPerPage={paginationDTO.NumPerPage}";
            }
            else
            {
                // Add query string.
                newURL = $"{url}?page={paginationDTO.Page}&numPerPage={paginationDTO.NumPerPage}";
            }

            var httpResponse = await httpService.Get<T>(newURL);
            var numPages = int.Parse(httpResponse.HttpResponseMessage.Headers.GetValues("numPages").FirstOrDefault());
            var paginatedResponse = new PaginatedResponse<T>
            {
                Response = httpResponse.Response,
                NumPages = numPages
            };

            return paginatedResponse;
        }
    }
}
