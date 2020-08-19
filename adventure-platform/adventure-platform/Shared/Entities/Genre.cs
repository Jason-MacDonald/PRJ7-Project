using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace adventureplatform.Shared.Entities
{
    public class Genre
    {
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }

        public List<AdventureGenre> GenreAdventures { get; set; } = new List<AdventureGenre>();
    }
}
