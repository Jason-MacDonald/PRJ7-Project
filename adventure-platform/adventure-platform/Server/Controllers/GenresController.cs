using adventureplatform.Shared.Entities;
using Microsoft.AspNetCore.Mvc;
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

        [HttpPost]
        public async Task<ActionResult> Post(Genre genre)
        {
            context.Add(genre);
            await context.SaveChangesAsync();
            return Ok();
        }
    }
}
