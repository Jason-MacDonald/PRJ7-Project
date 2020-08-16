using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace adventureplatform.Shared.Entities
{
    public class Adventure
    {
        public int ID { get; set; } = 1;
        public string Author { get; set; }
        [Required]
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public DateTime ReleaseDate { get; set; }       
    }
}
