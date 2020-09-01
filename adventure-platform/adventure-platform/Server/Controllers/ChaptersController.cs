using adventureplatform.Server.Helpers;
using adventureplatform.Shared.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace adventureplatform.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ChaptersController : ControllerBase
    {
        private readonly ApplicationDBContext context;
        private readonly IFileStorageService fileStorageService;

        public ChaptersController(ApplicationDBContext context, IFileStorageService fileStorageService)
        {
            this.context = context;
            this.fileStorageService = fileStorageService;
        }

        [HttpPost]
        public async Task<ActionResult<int>> Post(Chapter chapter)
        {
            if (!string.IsNullOrWhiteSpace(chapter.Image))
            {
                var adventureImage = Convert.FromBase64String(chapter.Image);
                chapter.Image = await fileStorageService.SaveFile(adventureImage, "jpg", "chapter");
            }

            context.Add(chapter);
            await context.SaveChangesAsync();
            return chapter.ID;
        }

        [HttpGet("{id}/list")]
        public async Task<ActionResult<List<Chapter>>> GetAll(int id)
        {
            var chapters = await context.Chapters.Where(x => x.AdventureID == id).ToListAsync();

            if (chapters == null)
            {
                return NotFound();
            }

            return chapters;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Chapter>> Get(int id)
        {
            var chapter = await context.Chapters.FirstOrDefaultAsync(x => x.ID == id);

            if (chapter == null)
            {
                return NotFound();
            }

            return chapter;
        }

        [HttpPut]
        public async Task<ActionResult<int>> Put(Chapter chapter)
        {
            if (!string.IsNullOrWhiteSpace(chapter.Image))
            {
                var adventureImage = Convert.FromBase64String(chapter.Image);
                chapter.Image = await fileStorageService.SaveFile(adventureImage, "jpg", "chapter");
            }

            context.Attach(chapter).State = EntityState.Modified;
            await context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var chapter = await context.Chapters.FirstOrDefaultAsync(x => x.ID == id);

            if(chapter == null)
            {
                return NotFound();
            }

            await context.Database.ExecuteSqlRawAsync($"delete from Links where ChapterID = {chapter.ID};");

            context.Remove(chapter);
            await context.SaveChangesAsync();
            return NoContent();
        }
    }
}
