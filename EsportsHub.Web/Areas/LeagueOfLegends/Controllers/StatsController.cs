using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace EsportsHub.Web.Areas.LeagueOfLegends.Controllers
{
    [Area("LeagueOfLegends")]
    public class StatsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Player()
        {
            return View();
        }

        public IActionResult Team()
        {
            return View();
        }
    }
}