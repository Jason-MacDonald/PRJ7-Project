﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace adventureplatform.Shared.Entities
{
    public class Adventure
    {
        // BASE PROPERTIES
        public int ID { get; set; } = 1;
        public string Author { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        public string Image { get; set; }
        public DateTime ReleaseDate { get; set; }

        // NAVIGATIONAL PROPERTIES
        public List<Chapter> Chapters { get; set; }

        public List<AdventureGenre> AdventureGenres { get; set; } = new List<AdventureGenre>();
        public List<UserFavourite> UserFavourites { get; set; } = new List<UserFavourite>();
        public List<UserProject> UserProjects { get; set; } = new List<UserProject>();
    }
}
