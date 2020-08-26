using adventureplatform.Client.Helpers;
using adventureplatform.Shared.Entities;
using adventureplatform.Shared.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace adventureplatform.Client.Repository
{
    public class AdventureRepository : IAdventureRepository
    {
        #region ##### HEAD #####

        private readonly IHttpService httpService;
        private readonly string url = "api/adventures";

        public AdventureRepository(IHttpService httpService)
        {
            this.httpService = httpService;
        }

        #endregion

        #region ##### POST #####

        public async Task<int> CreateAdventure(Adventure adventure)
        {
            var response = await httpService.Post<Adventure, int>(url, adventure);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;
        }

        #endregion

        #region ##### GET #####

        // Get All Adventures.
        public async Task<List<Adventure>> GetAdventures()
        {
            var response = await httpService.Get<List<Adventure>>(url);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;
        }

        // Get Adventure By ID.
        public async Task<Adventure> GetAdventure(int id)
        {
            var response = await httpService.Get<Adventure>($"{url}/{id}");
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;
        }

        // Get AdventureDTO By ID.
        public async Task<AdventureDTO> GetAdventureDTO(int id)
        {
            return await Get<AdventureDTO>($"{url}/{id}");
        }

        // Get AdventureUpdateDTO By ID.
        public async Task<AdventureUpdateDTO> GetAdventureUpdateDTO(int id)
        {
            return await Get<AdventureUpdateDTO>($"{url}/update/{id}");
        }

        // 
        private async Task<T> Get<T>(string url)
        {
            var response = await httpService.Get<T>(url);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;
        }

        #endregion

        #region ##### UPDATE #####

        public async Task UpdateAdventure(Adventure adventure)
        {
            var response = await httpService.Put(url, adventure);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }

        #endregion

        #region ##### DELETE #####

        // Delete Adventure By ID.
        public async Task DeleteAdventure(int id)
        {
            var response = await httpService.Delete($"{url}/{id}");

            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }

        #endregion







    }
}
