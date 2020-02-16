using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EsportsHub.API.Models
{
    public class DTResultSet
    {
        public int Draw;
        public int RecordsTotal;
        public int RecordsFiltered;
        public string Data;

        public DTResultSet(int draw, int recordsTotal, int recordsFiltered, string data)
        {
            Draw = draw;
            RecordsTotal = recordsTotal;
            RecordsFiltered = recordsFiltered;
            Data = data;
        }
    }
}
