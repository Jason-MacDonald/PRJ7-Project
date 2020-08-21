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

        public async Task CreateAdventure(Adventure adventure)
        {
            var response = await httpService.Post(url, adventure);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }
    }
}
