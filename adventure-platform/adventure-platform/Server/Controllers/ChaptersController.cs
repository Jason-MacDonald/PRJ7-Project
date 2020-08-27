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

        public ChaptersController(ApplicationDBContext context)
        {
            this.context = context;
        }

        [HttpPost]
        public async Task<ActionResult<int>> Post(Chapter chapter)
        {
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
