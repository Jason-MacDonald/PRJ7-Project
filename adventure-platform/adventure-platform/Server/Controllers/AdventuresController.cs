using adventureplatform.Server.Helpers;
using adventureplatform.Shared.Entities;
using AutoMapper;
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
        private readonly IFileStorageService fileStorageService;
        private readonly IMapper mapper;

        public AdventuresController(ApplicationDBContext context, IFileStorageService fileStorageService, IMapper mapper)
        {
            this.context = context;
            this.fileStorageService = fileStorageService;
            this.mapper = mapper;
        }

        [HttpPost]
        public async Task<ActionResult<int>> Post(Adventure adventure)
        {
            if (!string.IsNullOrWhiteSpace(adventure.Image))
            {
                var adventureImage = Convert.FromBase64String(adventure.Image);
                adventure.Image = await fileStorageService.SaveFile(adventureImage, "jpg", "adventure");
            }

            context.Add(adventure);
            await context.SaveChangesAsync();
            return adventure.ID;
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

        [HttpPut]
        public async Task<ActionResult<int>> Put(Adventure adventure)
        {
            var dbAdventure = await context.Adventures.FirstOrDefaultAsync(x => x.ID == adventure.ID);

            if(dbAdventure == null) { return NotFound(); }

            dbAdventure = mapper.Map(adventure, dbAdventure);

            if (!string.IsNullOrWhiteSpace(adventure.Image))
            {
                var adventureImage = Convert.FromBase64String(adventure.Image);
                dbAdventure.Image = await fileStorageService.EditFile(adventureImage, "jpg", "adventure", dbAdventure.Image);
            }

            await context.SaveChangesAsync();
            return NoContent();
        }
    }
}
