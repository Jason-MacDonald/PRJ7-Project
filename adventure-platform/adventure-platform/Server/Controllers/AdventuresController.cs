using adventureplatform.Server.Helpers;
using adventureplatform.Shared.DTOs;
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
        #region ##### HEAD #####

        private readonly ApplicationDBContext context;
        private readonly IFileStorageService fileStorageService;
        private readonly IMapper mapper;

        public AdventuresController(ApplicationDBContext context, IFileStorageService fileStorageService, IMapper mapper)
        {
            this.context = context;
            this.fileStorageService = fileStorageService;
            this.mapper = mapper;
        }

        #endregion

        #region ##### POST #####

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

        #endregion

        #region ##### GET #####

        // Get All Adventures
        [HttpGet]
        public async Task<ActionResult<List<Adventure>>> Get()
        {
            return await context.Adventures.ToListAsync();
        }

        // Get AdventureDTO By ID.
        [HttpGet("{id}")]
        public async Task<ActionResult<AdventureDTO>> Get(int id)
        {
            var adventure = await context.Adventures.Where(x => x.ID == id)
                .Include(x => x.AdventureGenres)
                .ThenInclude(x => x.Genre)
                .Include(x => x.Chapters )
                .FirstOrDefaultAsync();

            if(adventure == null) 
            { 
                return NotFound(); 
            }

            var model = new AdventureDTO();
            model.Adventure = adventure;
            model.GenreList = adventure.AdventureGenres.Select(x => x.Genre).ToList();
            model.ChapterList = adventure.Chapters.ToList();

            return model;
        }

        // Get AdventureUpdateDTO By ID --For Updating.
        [HttpGet("update/{id}")]
        public async Task<ActionResult<AdventureUpdateDTO>> PutGet(int id)
        {
            var adventureActionResult = await Get(id);

            if (adventureActionResult.Result is NotFoundResult)
            {
                return NotFound();
            }

            var adventureDTO = adventureActionResult.Value;
            var selectedGenreIDs = adventureDTO.GenreList.Select(x => x.ID).ToList();
            var notSelectedGenreList = await context.Genres
                .Where(x => !selectedGenreIDs.Contains(x.ID)).ToListAsync();

            var model = new AdventureUpdateDTO();
            model.Adventure = adventureDTO.Adventure;
            model.SelectedGenreList = adventureDTO.GenreList;
            model.NotSelectedGenreList = notSelectedGenreList;
            model.ChapterList = adventureDTO.ChapterList;

            return model;

        }

        #endregion

        #region ##### PUT #####

        // Update Adventure Using Adventure.
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

            // TODO: Deletes all from join tables. (should iterate?)
            await context.Database.ExecuteSqlRawAsync($"delete from AdventureGenres where AdventureID = {adventure.ID};");

            dbAdventure.AdventureGenres = adventure.AdventureGenres;

            await context.SaveChangesAsync();
            return NoContent();
        }

        #endregion

        #region ##### DELETE #####

        // Delete Adventure By ID --Cascade through links/chapters/adventure
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var adventure = await context.Adventures.FirstOrDefaultAsync(x => x.ID == id);
            
            if(adventure == null)
            {
                return NotFound();
            }

            await context.Database.ExecuteSqlRawAsync($"delete from Chapters where AdventureID = {adventure.ID};");

            context.Remove(adventure);
            await context.SaveChangesAsync();
            return NoContent();
        }

        #endregion

    }
}
