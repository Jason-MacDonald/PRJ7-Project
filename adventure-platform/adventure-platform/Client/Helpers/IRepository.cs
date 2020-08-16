using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using adventureplatform.Shared.Entities;

namespace adventureplatform.Client.Helpers
{
    public interface IRepository
    {
        List<Adventure> GetAdventures();
    }
}
