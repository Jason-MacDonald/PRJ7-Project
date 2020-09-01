using adventureplatform.Client.Helpers;
using adventureplatform.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace adventureplatform.Client.Repository
{
    public class ChapterRepository : IChapterRepository
    {
        private readonly IHttpService httpService;
        private readonly string url = "api/chapters";

        public ChapterRepository(IHttpService httpService)
        {
            this.httpService = httpService;
        }

        public async Task<int> CreateChapter(Chapter chapter)
        {
            var response = await httpService.Post<Chapter, int>(url, chapter);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;
        }

        public async Task<List<Chapter>> GetChapters(int id)
        {
            var response = await httpService.Get<List<Chapter>>($"{url}/{id}/list");
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;
        }

        public async Task<Chapter> GetChapter(int id)
        {
            var response = await httpService.Get<Chapter>($"{url}/{id}");
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;
        }

        public async Task UpdateChapter(Chapter chapter)
        {
            var response = await httpService.Put(url, chapter);

            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }

        public async Task DeleteChapter(int id)
        {
            var response = await httpService.Delete($"{url}/{id}");

            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }
    }
}
