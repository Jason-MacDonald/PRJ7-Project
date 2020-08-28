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

        public async Task CreateUserFavourite(UserFavourite userFavourite)
        {
            var response = await httpService.Post(url, userFavourite);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
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

        #region ##### DELETE #####

        public async Task DeleteUserFavourite(UserFavourite userFavourite)
        {
            var response = await httpService.Delete($"{url}/{userFavourite.UserID}/{userFavourite.AdventureID}");

            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }

        #endregion
    }
}
