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
    public class AdventuresController : ControllerBase
    {
        private readonly ApplicationDBContext context;

        public AdventuresController(ApplicationDBContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Adventure>>> Get()
        {
            return await context.Adventures.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Adventure>> Get(int id)
        {
            var adventure = await context.Adventures.FirstOrDefaultAsync(x => x.ID == id);
            if(adventure == null) 
            { 
                return NotFound(); 
            }
            return adventure;
        }

        //[HttpGet("{id}")]
        //public async Task<ActionResult<AdventureDTO>> Get(int id)
        //{
        //    var adventure = await context.Adventures.Where(x => x.ID == id)
        //        .Include(x => x.AdventureGenres).ThenInclude(x => x.Genre)
        //        .FirstOrDefaultAsync();

        //    if(adventure == null)
        //    {
        //        return NotFound();
        //    }

        //    adventure.Chapters = adventure.Chapters.ToList();

        //    var model = new AdventureDTO();
        //    model.adventure = adventure;
        //    model.genreList = adventure.AdventureGenres.Select(x => x.Genre).ToList();

        //    return model;
        //}

        [HttpPost]
        public async Task<ActionResult<int>> Post(Adventure adventure)
        {
            context.Add(adventure);
            await context.SaveChangesAsync();
            return adventure.ID;
        }

        [HttpPut]
        public async Task<ActionResult<int>> Put(Adventure adventure)
        {
            context.Attach(adventure).State = EntityState.Modified;
            await context.SaveChangesAsync();
            return NoContent();
        }
    }
}
