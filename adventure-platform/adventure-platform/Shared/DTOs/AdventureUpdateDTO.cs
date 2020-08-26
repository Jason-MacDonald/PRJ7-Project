using adventureplatform.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace adventureplatform.Shared.DTOs
{
    public class AdventureUpdateDTO
    {
        public Adventure Adventure { get; set; }
        public List<Genre> SelectedGenreList { get; set; }
        public List<Genre> NotSelectedGenreList { get; set; }
        public List<Chapter> ChapterList { get; set; }
    }
}
