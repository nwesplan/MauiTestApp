using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maui.Models.Routing
{
    public class RouteModel
    {
        public RouteModel()
        {

        }

        public RouteModel(string name, string route)
        {
            Name = name;
            Route = route;
        }

        public string Name { get; set; }
        public string Route { get; set; }
    }
}
