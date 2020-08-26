using adventureplatform.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace adventureplatform.Shared.DTOs
{
    public class AdventureDTO
    {
        public Adventure Adventure { get; set; }
        public List<Genre> GenreList { get; set; }
        public List<Chapter> ChapterList { get; set; }
    }
}
