using adventureplatform.Client.Helpers;
using adventureplatform.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace adventureplatform.Client.Repository
{
    public class UserFavouriteRepository : IUserFavouriteRepository
    {
        private readonly IHttpService httpService;
        private readonly string url = "api/userFavourites";

        public UserFavouriteRepository(IHttpService httpService)
        {
            this.httpService = httpService;
        }

        public async Task<List<UserFavourite>> GetUserFavourites()
        {
            var response = await httpService.Get<List<UserFavourite>>(url);

            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }

            return response.Response;
        }
    }
}
