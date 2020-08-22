using adventureplatform.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace adventureplatform.Client.Repository
{
    public interface IChapterRepository
    {
        Task CreateChapter(Chapter chapter);
        Task<Chapter> GetChapter(int id);
        Task<List<Chapter>> GetChapters(int adventureID);
        Task UpdateChapter(Chapter chapter);
    }
}
