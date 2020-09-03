using adventureplatform.Shared.Entities;
using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace adventureplatform.Server.Handlers
{
    public class AdventureHandler : AuthorizationHandler<SameAuthorRequirement, Adventure>
    {
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, SameAuthorRequirement requirement, Adventure resource)
        {
            if(context.User.Identity?.Name == resource.Author)
            {
                context.Succeed(requirement);
            }

            return Task.CompletedTask;
        }
    }

    public class SameAuthorRequirement : IAuthorizationRequirement { }
}
