using adventureplatform.Client.Helpers;
using adventureplatform.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace adventureplatform.Client.Repository
{
    public class UserProjectRepository : IUserProjectRepository
    {
        private readonly IHttpService httpService;
        private readonly string url = "api/userProjects";

        public UserProjectRepository(IHttpService httpService)
        {
            this.httpService = httpService;
        }
    }
}
