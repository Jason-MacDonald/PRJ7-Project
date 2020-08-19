using System;
using System.Collections.Generic;
using System.Text;

namespace adventureplatform.Shared.Entities
{
    public class AdventureGenre
    {
        // BASE PROPERTIES
        public int AdventureID {get; set;}
        public int GenreID { get; set; }

        // NAVIGATIONAL PROPERTIES
        public Adventure Adventure { get; set; }
        public Genre Genre { get; set; }
    }
}
