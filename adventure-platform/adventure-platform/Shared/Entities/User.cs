﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace adventureplatform.Shared.Entities
{
    public class User
    {
        public int ID { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }

        public List<UserFavourite> UserFavourites { get; set; } = new List<UserFavourite>();
        public List<UserProject> UserProjects { get; set; } = new List<UserProject>();
    }
}
