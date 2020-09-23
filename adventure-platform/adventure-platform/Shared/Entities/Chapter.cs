using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace adventureplatform.Shared.Entities
{
    public class Chapter
    {
        // BASE PROPERTIES
        public int ID { get; set; }
        [Required]
        [StringLength(100, ErrorMessage = "Title too long (100 character limit).")]
        public string Title { get; set; }
        public string Image { get; set; }
        [Required]
        [StringLength(500, ErrorMessage = "Description too long (500 character limit).")]
        public string Description { get; set; }
        [StringLength(500, ErrorMessage = "Event too long (500 character limit).")]
        public string Event { get; set; }
        [StringLength(500, ErrorMessage = "Help too long (500 character limit).")]
        public string Help { get; set; }

        // NAVIGATIONAL PROPERTIES
        public int AdventureID { get; set; }

        public List<Link> Links { get; set; } = new List<Link>();
    }
}
