using System;
using System.Collections.Generic;
using System.Text;

namespace adventureplatform.Shared.Entities
{
    public class UserFavourite
    {
        // BASE PROPERTIES
        public string UserID { get; set; }
        public int AdventureID { get; set; }

        public int CurrentChapter { get; set; }

        // NAVIGATIONAL PROPERTIES
        //public User User { get; set; }
        public Adventure Favourite { get; set; }
    }
}
