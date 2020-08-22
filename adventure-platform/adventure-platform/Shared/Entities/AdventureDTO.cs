using System;
using System.Collections.Generic;
using System.Text;

namespace adventureplatform.Shared.Entities
{
    public class AdventureDTO
    {
        public Adventure adventure { get; set; }
        public List<Genre> genreList { get; set; }
        public List<Chapter> chapterList { get; set; }
    }
}
