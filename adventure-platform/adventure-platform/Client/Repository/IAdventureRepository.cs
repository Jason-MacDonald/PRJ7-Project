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
        Task DeleteAdventure(int id);
        Task<Adventure> GetAdventure(int id);
        Task<AdventureDTO> GetAdventureDTO(int id);
        Task<List<Adventure>> GetAdventures();
        Task<AdventureUpdateDTO> GetAdventureUpdateDTO(int id);
        Task UpdateAdventure(Adventure adventure);
    }
}
