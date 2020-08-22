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
        private readonly string url = "api/links";

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

        public async Task<List<Link>> GetLinks(int id)
        {
            var response = await httpService.Get<List<Link>>($"{url}/{id}/list");
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;
        }

        public async Task<Link> GetLink(int id)
        {
            var response = await httpService.Get<Link>($"{url}/{id}");
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;
        }

        public async Task UpdateLink(Link link)
        {
            var response = await httpService.Put(url, link);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }
    }
}
