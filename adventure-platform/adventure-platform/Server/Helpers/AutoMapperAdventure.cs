﻿using AutoMapper;
using adventureplatform.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace adventureplatform.Server.Helpers
{
    public class AutoMapperAdventure : Profile
    {
        public AutoMapperAdventure()
        {
            // Image only updated if changed.
            CreateMap<Adventure, Adventure>().ForMember(x => x.Image, Base64FormattingOptions => Base64FormattingOptions.Ignore());
        }
    }
}
