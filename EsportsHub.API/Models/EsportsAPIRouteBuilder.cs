using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EsportsHub.API.Models
{
    public static class EsportsAPIRouteBuilder
    {
        private static string route = "";

        public static string dtRoute(int id, DTParameters dtParams)
        {
            var page = (dtParams.Start / dtParams.Length) + 1;

            return "";
        }
    }
}
