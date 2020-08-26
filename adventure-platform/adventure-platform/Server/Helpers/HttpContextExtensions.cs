using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace adventureplatform.Server.Helpers
{
    public static class HttpContextExtensions
    {
        /// <summary>
        /// 
        /// </summary>
        public async static Task InsertPaginationParametersInResponse<T>(this HttpContext httpContext,
            IQueryable<T> queryable, int numPerPage)
        {
            if(httpContext == null)
            {
                throw new ApplicationException(nameof(httpContext));
            }

            double count = await queryable.CountAsync();
            double numPages = Math.Ceiling(count / numPerPage);

            httpContext.Response.Headers.Add("numPages", numPages.ToString());
        }
    }
}
