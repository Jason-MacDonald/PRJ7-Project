using adventureplatform.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace adventureplatform.Client.Repository
{
    public interface IAdventureRepository
    {
        Task CreateAdventure(Adventure adventure);
        Task<AdventureDTO> GetAdventureDTO(int id);
        Task<List<Adventure>> GetAdventures();
    }
}
