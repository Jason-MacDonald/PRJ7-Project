using adventureplatform.Client.Helpers;
using adventureplatform.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace adventureplatform.Client.Repository
{
    public class LinkRepository : ILinkRepository
    {
        private readonly IHttpService httpService;
        private string url = "api/links";

        public LinkRepository(IHttpService httpService)
        {
            this.httpService = httpService;
        }

        public async Task CreateLink(Link link)
        {
            var response = await httpService.Post(url, link);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }
    }
}
