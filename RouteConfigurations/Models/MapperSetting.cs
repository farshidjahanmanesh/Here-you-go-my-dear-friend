using System;
using System.Collections.Generic;
using System.Linq;

namespace RouteConfigurations.Models
{
    public class MapperSetting
    {
        public List<RouteMapBuilder> Mappers { get; private set; }
        public MapperSetting()
        {
            Mappers = new List<RouteMapBuilder>();
        }
        public MapperSetting AddRoute(RouteMapBuilder route)
        {
            if(Mappers.Any(c => c.Name == route.Name))
            {
                throw new Exception("the route name is duplicated");
            }
            Mappers.Add(route);
            return this;
        }
        public List<string> ListOfRoutes()
        {
            return Mappers.Select(c => c.Pattern).ToList();
        }

    }
}
