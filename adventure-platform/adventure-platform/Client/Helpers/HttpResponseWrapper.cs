using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace adventureplatform.Client.Helpers
{
    public class HttpResponseWrapper<T>
    {

        #region ##### HEAD #####

        public bool Success { get; set; }
        public T Response { get; set; }
        public HttpResponseMessage HttpResponseMessage { get; set; }

        public HttpResponseWrapper(T response, bool success, HttpResponseMessage httpResponseMessage)
        {
            Success = success;
            Response = response;
            HttpResponseMessage = httpResponseMessage;
        }

        #endregion

        #region ##### GENERAL #####

        // Used to provide error message when ApplicationException is thrown during communication with database.
        public async Task<string> GetBody()
        {
            return await HttpResponseMessage.Content.ReadAsStringAsync();
        }

        #endregion

    }
}
