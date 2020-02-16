using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using EsportsHub.API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System.IO;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EsportsHub.API.Controllers.LeagueOfLegends
{
    [Route("api/lol/[controller]/[action]")]
    [ApiController]
    public class TournamentsController : Controller
    {
        private readonly ILogger<ChampionsController> _logger;
        private readonly HttpClient _client;

        private string route = "tournaments/";

        public TournamentsController(ILogger<ChampionsController> logger, IHttpClientFactory clientFactory)
        {
            _logger = logger;
            _client = clientFactory.CreateClient(Constants.ApiService.name);
        }

        // GET: api/lol/tournaments/GetPlayers/5
        [HttpGet]
        public async Task<IActionResult> GetPlayers([FromQuery]int id, [FromQuery]DTParameters dtParams)
        {
            route = "tournaments/" + id + "/players";
            //route = EsportsAPIRouteBuilder.dtRoute(id, dtParams);
            var resp = await _client.GetAsync(Constants.LeagueOfLegends.route + route);
            var content = await resp.Content.ReadAsStringAsync();

            Debug.WriteLine(content);

            if (!resp.IsSuccessStatusCode)
            {
                return Ok();
            }

            var json = JsonConvert.DeserializeObject(content);
            Debug.WriteLine(json);

            return Ok(new
            {
                draw = dtParams.Draw,
                recordsFiltered = 123,
                recordsTotal = 234,
                data = content
            });
        }
    }
}
