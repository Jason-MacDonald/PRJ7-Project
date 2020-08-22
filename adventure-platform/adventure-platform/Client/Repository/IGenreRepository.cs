using adventureplatform.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace adventureplatform.Client.Repository
{
    public interface IGenreRepository
    {
        Task CreateGenre(Genre genre);
        Task<List<Genre>> GetGenre(int id);
        Task<List<Genre>> GetGenres();
        Task UpdateGenre(Genre genre);
    }
}
