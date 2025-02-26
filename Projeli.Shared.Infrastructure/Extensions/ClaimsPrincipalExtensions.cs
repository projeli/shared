using System.Security.Claims;
using Projeli.Shared.Application.Exceptions.Http;
using Projeli.Shared.Domain.Extensions;

namespace Projeli.Shared.Infrastructure.Extensions;

public static class ClaimsPrincipalExtensions
{
    public static string GetId(this ClaimsPrincipal principal)
    {
        var userId = principal.Claims.FirstOrDefault(x => x.Type.EqualsIgnoreCase(ClaimTypes.NameIdentifier))?.Value;
        
        if (userId is null)
        {
            throw new UnauthorizedException("User id not found in claims");
        }
        
        return userId;
    }

    public static string? TryGetId(this ClaimsPrincipal principal)
    {
        try
        {
            return principal.GetId();
        }
        catch (UnauthorizedException)
        {
            return null;
        }
    }
}