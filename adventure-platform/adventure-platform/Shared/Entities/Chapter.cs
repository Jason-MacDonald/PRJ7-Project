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
        [StringLength(5000, ErrorMessage = "Chapter description too long (5000 character limit).")]
        public string Description { get; set; }
        [StringLength(5000, ErrorMessage = "Chapter event too long (5000 character limit).")]
        public string Event { get; set; }
        [StringLength(5000, ErrorMessage = "Chapter help too long (5000 character limit).")]
        public string Help { get; set; }

        // NAVIGATIONAL PROPERTIES
        public int AdventureID { get; set; }

        public List<Link> Links { get; set; } = new List<Link>();
    }
}
