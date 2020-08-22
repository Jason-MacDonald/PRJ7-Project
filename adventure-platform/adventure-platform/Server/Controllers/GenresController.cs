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
    public class GenresController : ControllerBase
    {
        private readonly ApplicationDBContext context;

        public GenresController(ApplicationDBContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Genre>>> Get()
        {
            return await context.Genres.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Genre>> Get(int id)
        {
            var genre = await context.Genres.FirstOrDefaultAsync(x => x.ID == id);
            if(genre == null) 
            { 
                return NotFound(); 
            }
            return genre;
        }

        [HttpPost]
        public async Task<ActionResult> Post(Genre genre)
        {
            context.Add(genre);
            await context.SaveChangesAsync();
            return Ok();
        }

        [HttpPut]
        public async Task<ActionResult> Put(Genre genre)
        {
            context.Attach(genre).State = EntityState.Modified;
            await context.SaveChangesAsync();
            return NoContent();
        }

    }
}
