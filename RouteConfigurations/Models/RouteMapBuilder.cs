using System.Text;

namespace RouteConfigurations.Models
{
    public class RouteMapBuilder
    {
        public string Pattern { get; private set; } = null;
        public string Name { get; private set; } = null;
        public object DefaultObj { get; private set; } = null;
        public object Constraints { get; private set; } = null;
        public object DataTokens { get; private set; } = null;
        public RouteMapBuilder(string name, string pattern)
        {
            this.Name = name;
            this.Pattern = pattern;
        }
        public RouteMapBuilder SetDefault(object defObject)
        {
            this.DefaultObj = defObject;
            return this;
        }
        public RouteMapBuilder SetConstraints(object constraints)
        {
            this.Constraints = constraints;
            return this;
        }
        public RouteMapBuilder SetDataTokens(object dataTokens)
        {
            this.DataTokens = dataTokens;
            return this;
        }
    }
}
