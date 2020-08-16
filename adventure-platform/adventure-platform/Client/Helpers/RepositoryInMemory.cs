using adventureplatform.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace adventureplatform.Client.Helpers
{
    public class RepositoryInMemory : IRepository
    {
        public List<Adventure> GetAdventures()
        {
            return new List<Adventure>()
            {
                new Adventure() 
                { 
                    Author = "Jason MacDonald", 
                    Title = "The Cloud Dungeon",
                    Description = "This is the description for The Cloud Dungeon.",
                    Image = "https://cf.geekdo-images.com/imagepage/img/qPXbAKRbfk0QRSxAtAOfk1U57oM=/fit-in/900x600/filters:no_upscale()/pic2633084.png",
                    ReleaseDate = new DateTime(2019, 7, 2)
                },
                new Adventure()
                {
                    Author = "Jason MacDonald",
                    Title = "The Sunken Dungeon",
                    Description = "This is the description for The Sunken Dungeon.",
                    Image = "https://ksr-ugc.imgix.net/assets/028/389/346/f9d50f86970fcd55335e58b8e96df336_original.png?ixlib=rb-2.1.0&crop=faces&w=1552&h=873&fit=crop&v=1583867611&auto=format&frame=1&q=92&s=c7e69fa7b62d19dd57584c5b3732eea6",
                    ReleaseDate = new DateTime(2020, 7, 2)
                }
            };
        }
    }
}
