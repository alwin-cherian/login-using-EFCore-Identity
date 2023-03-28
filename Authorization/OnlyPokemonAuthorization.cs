using Microsoft.AspNetCore.Authorization;

namespace Week6_Identity_CRUD.Authorization
{
    public class OnlyPokemonAuthorization : AuthorizationHandler<OnlyPokemonAuthorization>, IAuthorizationRequirement
    {
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, OnlyPokemonAuthorization requirement)
        {
            if (context.User.IsInRole("Pokemon"))
            {
                context.Succeed(requirement);
                return Task.CompletedTask;
            }
            return Task.CompletedTask;
        }
    }
}
