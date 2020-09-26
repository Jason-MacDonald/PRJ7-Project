using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace adventureplatform.Shared.Entities
{
    public class Adventure
    {
        // BASE PROPERTIES
        public int ID { get; set; }
        public string Author { get; set; }
        [Required]
        [StringLength(100, ErrorMessage = "Title too long (100 character limit).")]
        public string Title { get; set; }
        [Required]
        [StringLength(2000, ErrorMessage = "Description too long (2000 character limit).")]
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
