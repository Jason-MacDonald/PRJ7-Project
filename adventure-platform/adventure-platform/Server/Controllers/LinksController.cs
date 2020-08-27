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
    public class LinksController : ControllerBase
    {
        private readonly ApplicationDBContext context;

        public LinksController(ApplicationDBContext context)
        {
            this.context = context;
        }

        [HttpPost]
        public async Task<ActionResult<int>> Post(Link link)
        {
            context.Add(link);
            await context.SaveChangesAsync();
            return link.ID;
        }

        [HttpGet("{id}/list")]
        public async Task<ActionResult<List<Link>>> GetAll(int id)
        {
            var links = await context.Links.Where(x => x.ChapterID == id).ToListAsync();

            if(links == null)
            {
                return NotFound();
            }

            return links;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Link>> Get(int id)
        {
            var link = await context.Links.FirstOrDefaultAsync(x => x.ID == id);

            if (link == null)
            {
                return NotFound();
            }

            return link;
        }

        [HttpPut]
        public async Task<ActionResult<int>> Put(Link link)
        {
            context.Attach(link).State = EntityState.Modified;
            await context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var link = await context.Links.FirstOrDefaultAsync(x => x.ID == id);

            if(link == null)
            {
                return NotFound();
            }

            context.Remove(link);
            await context.SaveChangesAsync();
            return NoContent();
        }
    }
}
