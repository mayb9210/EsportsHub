using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace EsportsHub.Web.Controllers.Fantasy
{
    public class LeagueOfLegendsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}