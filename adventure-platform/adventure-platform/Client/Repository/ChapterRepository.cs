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
        private string url = "api/chapters";

        public ChapterRepository(IHttpService httpService)
        {
            this.httpService = httpService;
        }

        public async Task CreateChapter(Chapter chapter)
        {
            var response = await httpService.Post(url, chapter);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }
    }
}
