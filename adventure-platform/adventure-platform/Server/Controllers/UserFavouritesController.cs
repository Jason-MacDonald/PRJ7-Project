using adventureplatform.Shared.DTOs;
using adventureplatform.Shared.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;


namespace adventureplatform.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserFavouritesController : ControllerBase
    {
        private readonly ApplicationDBContext context;

        public UserFavouritesController(ApplicationDBContext context)
        {
            this.context = context;
        }
        #region ##### POST #####

        [HttpPost]
        public async Task<ActionResult> Post(UserFavourite userFavourite)
        {
            context.Add(userFavourite);
            await context.SaveChangesAsync();
            return Ok();
        }

        #endregion


        [HttpGet]
        public async Task<ActionResult<List<UserFavourite>>> GetUserFavourites(string userID)
        {
            return await context.UserFavourites.Where(x => x.UserID == userID).ToListAsync();
            //return new List<UserFavourite>{ new UserFavourite{ UserID = userID, AdventureID = 1, Favourite = null } };
        }

        #region ##### DELETE #####

        [HttpDelete("{userID}/{id}")]
        public async Task<ActionResult> Delete(string userID, int id)
        {
            var userFavourite = await context.UserFavourites.FirstOrDefaultAsync(x => x.AdventureID == id && x.UserID == userID);

            if (userFavourite == null)
            {
                return NotFound();
            }

            context.Remove(userFavourite);
            await context.SaveChangesAsync();
            return NoContent();
        }

        #endregion
    }
}
