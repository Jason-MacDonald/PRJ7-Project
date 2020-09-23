using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace adventureplatform.Shared.Entities
{
    public class Genre
    {
        // BASE PROPERTIES
        public int ID { get; set; }
        [Required]
        [StringLength(25, ErrorMessage = "Genre too long (25 character limit).")]
        public string Name { get; set; }

        // NAVIGATIONAL PROPERTIES
        public List<AdventureGenre> GenreAdventures { get; set; } = new List<AdventureGenre>();
    }
}
