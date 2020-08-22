using adventureplatform.Client.Helpers;
using adventureplatform.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace adventureplatform.Client.Repository
{
    public class AdventureRepository : IAdventureRepository
    {
        private readonly IHttpService httpService;
        private string url = "api/adventures";

        public AdventureRepository(IHttpService httpService)
        {
            this.httpService = httpService;
        }

        public async Task<List<Adventure>> GetAdventures()
        {
            var response = await httpService.Get<List<Adventure>>(url);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;
        }

        public async Task<Adventure> GetAdventure(int id)
        {
            var response = await httpService.Get<Adventure>($"{url}/{id}");
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;
        }

        //public async Task<AdventureDTO> GetAdventureDTO(int id)
        //{
        //    return await Get<AdventureDTO>($"{url}/{id}");
        //}

        public async Task<T> Get<T>(string url)
        {
            var response = await httpService.Get<T>(url);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;
        }

        public async Task CreateAdventure(Adventure adventure)
        {
            var response = await httpService.Post(url, adventure);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }

        public async Task UpdateAdventure(Adventure adventure)
        {
            var response = await httpService.Put(url, adventure);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }
    }
}
