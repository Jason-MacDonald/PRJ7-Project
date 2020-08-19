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
        public string Title { get; set; }
        public string Images { get; set; }
        [Required]
        public string Description { get; set; }
        public string Event { get; set; }
        public string Help { get; set; }

        // NAVIGATIONAL PROPERTIES
        public List<Link> Links { get; set; } = new List<Link>();
    }
}
