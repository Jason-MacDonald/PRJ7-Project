using adventureplatform.Shared.Entities;
using Microsoft.AspNetCore.Authorization;
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

        #region ##### HEAD #####

        private readonly ApplicationDBContext context;
        private readonly IAuthorizationService _authorizationService;

        public GenresController(ApplicationDBContext context, IAuthorizationService authorizationService)
        {
            this.context = context;
            _authorizationService = authorizationService;
        }

        #endregion

        #region ##### POST #####

        [HttpPost]
        public async Task<ActionResult> Post(Genre genre)
        {
            context.Add(genre);
            await context.SaveChangesAsync();
            return Ok();
        }

        #endregion

        #region ##### GET #####

        // Get All Genres.
        [HttpGet]
        public async Task<ActionResult<List<Genre>>> Get()
        {
            return await context.Genres.ToListAsync();
        }

        // Get Genre By ID.
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

        #endregion

        #region ##### PUT #####

        [HttpPut]
        public async Task<ActionResult> Put(Genre genre)
        {
            context.Attach(genre).State = EntityState.Modified;
            await context.SaveChangesAsync();
            return NoContent();
        }

        #endregion

        #region ##### DELETE #####

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var genre = await context.Genres.FirstOrDefaultAsync(x => x.ID == id);
           
            if(genre == null)
            {
                return NotFound();
            }

            context.Remove(genre);
            await context.SaveChangesAsync();
            return NoContent();
        }

        #endregion

    }
}