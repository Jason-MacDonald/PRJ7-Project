using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace adventureplatform.Shared.Entities
{
    public class Link
    {
        public int ID { get; set; }
        [Required]
        public string Description { get; set; }
        public int Target { get; set; }
    }
}
