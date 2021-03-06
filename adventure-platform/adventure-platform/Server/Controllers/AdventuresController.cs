﻿using adventureplatform.Server.Helpers;
using adventureplatform.Shared.DTOs;
using adventureplatform.Shared.Entities;
using AutoMapper;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
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
    //[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class AdventuresController : ControllerBase
    {
        #region ##### HEAD #####

        private readonly ApplicationDBContext context;
        private readonly IFileStorageService fileStorageService;
        private readonly IMapper mapper;
        private readonly IAuthorizationService _authorizationService;

        public AdventuresController
        (
            ApplicationDBContext context, 
            IFileStorageService fileStorageService, 
            IMapper mapper, 
            IAuthorizationService authorizationService
        )
        {
            this.context = context;
            this.fileStorageService = fileStorageService;
            this.mapper = mapper;
            this._authorizationService = authorizationService;
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

            // Save user project.
            await context.Database.ExecuteSqlRawAsync($"insert into UserProjects (UserID, AdventureID) values ('{adventure.Author}', {adventure.ID});");
            
            return adventure.ID;
        }

        #endregion

        #region ##### GET #####

        // Get All Adventures --Using pagination for range of results.
        [HttpGet]
        [AllowAnonymous]
        public async Task<ActionResult<List<Adventure>>> Get([FromQuery]PaginationDTO paginationDTO) // FromQuery allows the use of query strings.
        {
            var queryable = context.Adventures.AsQueryable();
            await HttpContext.InsertPaginationParametersInResponse(queryable, paginationDTO.NumPerPage);

            return await queryable.Paginate(paginationDTO).ToListAsync();
        }

        // Get AdventureDTO By ID.
        [HttpGet("{id}")]
        [AllowAnonymous]
        public async Task<ActionResult<AdventureDTO>> Get(int id)
        {
            var adventure = await context.Adventures.Where(x => x.ID == id)
                .Include(x => x.AdventureGenres)
                .ThenInclude(x => x.Genre)
                .Include(x => x.Chapters )
                .ThenInclude(x => x.Links)
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

        [HttpPost("filter")]
        [AllowAnonymous]
        public async Task<ActionResult<List<Adventure>>> Filter(AdventureFilterDTO adventureFilterDTO)
        {
            var adventuresQueryable = context.Adventures.AsQueryable();

            if (adventureFilterDTO.GenreID != 0)
            {
                adventuresQueryable = adventuresQueryable
                    .Where(x => x.AdventureGenres.Select(y => y.GenreID)
                    .Contains(adventureFilterDTO.GenreID));
            }

            await HttpContext.InsertPaginationParametersInResponse(adventuresQueryable, adventureFilterDTO.NumPerPage);

            var adventures = await adventuresQueryable.Paginate(adventureFilterDTO.Pagination).ToListAsync();

            return adventures;
        }

        [HttpPost("favourites")]
        public async Task<ActionResult<List<Adventure>>> GetFavourites(UserFavouritesDTO userFavouritesDTO)
        {
            var userFavouritesQueryable = context.Adventures.AsQueryable();

            if (!string.IsNullOrEmpty(userFavouritesDTO.UserEmail))
            {
                userFavouritesQueryable = userFavouritesQueryable
                    .Where(x => x.UserFavourites.Select(y => y.UserID)
                    .Contains(userFavouritesDTO.UserEmail));
            }

            await HttpContext.InsertPaginationParametersInResponse(userFavouritesQueryable, userFavouritesDTO.NumPerPage);

            var favourites = await userFavouritesQueryable.Paginate(userFavouritesDTO.Pagination).ToListAsync();

            return favourites;
        }

        [HttpPost("projects")]
        public async Task<ActionResult<List<Adventure>>> GetProjects(UserProjectsDTO userProjectsDTO)
        {
            var userProjectsQueryable = context.Adventures.AsQueryable();

            if (!string.IsNullOrEmpty(userProjectsDTO.UserEmail))
            {
                userProjectsQueryable = userProjectsQueryable
                    .Where(x => x.UserProjects.Select(y => y.UserID)
                    .Contains(userProjectsDTO.UserEmail));
            }

            await HttpContext.InsertPaginationParametersInResponse(userProjectsQueryable, userProjectsDTO.NumPerPage);

            var favourites = await userProjectsQueryable.Paginate(userProjectsDTO.Pagination).ToListAsync();

            return favourites;
        }


        #endregion

        #region ##### PUT #####

        // Update Adventure Using Adventure.
        [HttpPut]
        public async Task<ActionResult<int>> Put(Adventure adventure)
        {

            // TODO: How do I athenticate and set the user property?


            ////TEST
            //var authorizationResult = await _authorizationService.AuthorizeAsync(User, adventure, "EditPolicy");

            //if (authorizationResult.Succeeded)
            //{
            //    //END TEST

                var dbAdventure = await context.Adventures.FirstOrDefaultAsync(x => x.ID == adventure.ID);

                if (dbAdventure == null)
                {
                    return NotFound();
                }

                dbAdventure = mapper.Map(adventure, dbAdventure);

                if (!string.IsNullOrWhiteSpace(adventure.Image))
                {
                    var adventureImage = Convert.FromBase64String(adventure.Image);
                    dbAdventure.Image = await fileStorageService.EditFile(adventureImage, "jpg", "adventure", dbAdventure.Image);
                }

                await context.Database.ExecuteSqlRawAsync($"delete from AdventureGenres where AdventureID = {adventure.ID};");

                dbAdventure.AdventureGenres = adventure.AdventureGenres;

                await context.SaveChangesAsync();
                return NoContent();

            //    //TEST
            //}
            //else if (User.Identity.IsAuthenticated)
            //{
            //    return new ForbidResult();
            //}
            //else
            //{
            //    return new ChallengeResult();
            //}
            ////END TEST          
        }

        #endregion

        #region ##### DELETE #####

        // Delete Adventure By ID --Manually cascade through links/chapters/adventure
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
