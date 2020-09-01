using adventureplatform.Shared.DTOs;
using adventureplatform.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace adventureplatform.Client.Repository
{
    public interface IAdventureRepository
    {
        Task<int> CreateAdventure(Adventure adventure);
        Task<PaginatedResponse<List<Adventure>>> GetAdventures(PaginationDTO paginationDTO);
        Task<Adventure> GetAdventure(int id);
        Task<AdventureDTO> GetAdventureDTO(int id);
        
        Task<AdventureUpdateDTO> GetAdventureUpdateDTO(int id);
        Task UpdateAdventure(Adventure adventure);
        Task DeleteAdventure(int id);
        Task<PaginatedResponse<List<Adventure>>> GetFilteredAdventures(AdventureFilterDTO adventureFilterDTO);
        Task<PaginatedResponse<List<Adventure>>> GetUserFavourites(UserFavouritesDTO userFavouritesDTO);
        Task<PaginatedResponse<List<Adventure>>> GetUserProjects(UserProjectsDTO userProjectsDTO);
    }
}
