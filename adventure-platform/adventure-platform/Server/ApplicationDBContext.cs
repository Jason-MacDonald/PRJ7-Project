using adventureplatform.Shared.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace adventureplatform.Server
{
    public class ApplicationDBContext : IdentityDbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {

        }

        // REQUIRED FOR COMPOSITE KEYS
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Required for composite keys.
            modelBuilder.Entity<AdventureGenre>().HasKey(x => new { x.AdventureID, x.GenreID });
            modelBuilder.Entity<UserFavourite>().HasKey(x => new { x.UserID, x.AdventureID });
            modelBuilder.Entity<UserProject>().HasKey(x => new { x.UserID, x.AdventureID });

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Adventure> Adventures { get; set; }
        public DbSet<AdventureGenre> AdventureGenres {get; set;}
        public DbSet<Chapter> Chapters { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Link> Links { get; set; }
        public DbSet<UserFavourite> UserFavourites { get; set; }
        public DbSet<UserProject> UserProjects { get; set; }
    }
}
