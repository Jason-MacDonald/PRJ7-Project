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
    public class AdventuresController : ControllerBase
    {
        private readonly ApplicationDBContext context;

        public AdventuresController(ApplicationDBContext context)
        {
            this.context = context;
        }

        [HttpPost]
        public async Task<ActionResult<int>> Post(Adventure adventure)
        {
            context.Add(adventure);
            await context.SaveChangesAsync();
            return adventure.ID;
        }
    }
}
