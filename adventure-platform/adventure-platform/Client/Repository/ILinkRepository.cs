﻿using adventureplatform.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace adventureplatform.Client.Repository
{
    public interface ILinkRepository
    {
        Task<int> CreateLink(Link link);
        Task DeleteLink(int id);
        Task<Link> GetLink(int id);
        Task<List<Link>> GetLinks(int id);
        Task UpdateLink(Link link);
    }
}
