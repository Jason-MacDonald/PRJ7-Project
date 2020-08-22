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
    }

}
