using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace EsportsHub.Web.Areas.Stats.Controllers
{
    [Area("LeagueOfLegends")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}