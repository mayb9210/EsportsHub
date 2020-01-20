using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EsportsHub.API
{
    public static class Constants
    {
        public static class ApiService
        {
            public const string name = "PandaScore";
            public const string uri = "https://api.pandascore.co";
            public const string token = "YzVWo_Qvp1f2FOpV6YJqOXN6HhizkzLNG7BquBH6ntURzjE0WQg";
        }

        public static class LeagueOfLegends
        {
            public const string route = "lol";
        }

        public static class Use
        {
            private static string parameters = "?";

            public static void setParameters(List<KeyValuePair<string, string>> p)
            {
                var myParams = parameters;
                if (p.Count > 0)
                {
                    foreach (var param in p)
                    {
                        myParams = param.Key + "=" + param.Value + "&";
                    }

                    parameters = parameters.Substring(0, (myParams.Length - 1));
                }
            }

            public static string getParameters()
            {
                return parameters;
            }
        }
    }
}
