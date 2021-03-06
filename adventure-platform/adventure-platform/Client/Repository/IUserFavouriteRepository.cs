﻿using adventureplatform.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace adventureplatform.Client.Repository
{
    public interface IUserFavouriteRepository
    {
        Task CreateUserFavourite(UserFavourite userFavourite);
        Task DeleteUserFavourite(UserFavourite userFavourite);
        Task<List<UserFavourite>> GetUserFavourites();
    }
}
