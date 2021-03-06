using RouteConfigurations.contracts;
using Microsoft.AspNetCore.Routing;
using Microsoft.AspNetCore.Builder;

namespace RouteConfigurations.Models
{
    public static class RouteEndpointBuilderExtensions
    {

        public static void MapperEndPoint(this IEndpointRouteBuilder
            endpoints, IProfileRouteMapper profileRoute)
        {
            var setting = new MapperSetting();
            profileRoute.Routes(setting);
            foreach (var route in setting.Mappers)
            {
                endpoints.MapControllerRoute(
                    route.Name, route.Pattern,
                    route.DefaultObj, route.Constraints,
                   route.DataTokens);
            }

        }
    }
}
