using System;
using System.Collections.Generic;
using System.Text;

namespace adventureplatform.Shared.Entities
{
    public class UserProject
    {
        // BASE PROPERTIES
        public string UserID { get; set; }
        public int AdventureID { get; set; }

        // NAVIGATIONAL PROPERTIES
        //public User User { get; set; }
        public Adventure Project { get; set; }
    }
}
