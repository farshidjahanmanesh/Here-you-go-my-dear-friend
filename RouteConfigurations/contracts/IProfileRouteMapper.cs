using RouteConfigurations.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RouteConfigurations.contracts
{
    public interface IProfileRouteMapper
    {
        MapperSetting Routes(MapperSetting setting);
    }
}
