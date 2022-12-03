using System.Security.Claims;

namespace ExeGuide.DataBase.Infrastructure
{
    public static class ClaimsPrincipalExtentions
    {
            public static string Id(this ClaimsPrincipal user) => user.FindFirst(ClaimTypes.NameIdentifier).Value;
      
    }
}
