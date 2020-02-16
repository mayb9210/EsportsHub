using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;

namespace EsportsHub.API.Controllers.LeagueOfLegends
{
    [Route("api/lol/[controller]")]
    [ApiController]
    public class PlayersController : ControllerBase
    {
        private readonly ILogger<ChampionsController> _logger;
        private readonly HttpClient _client;
         
        private string route = "players";

        public PlayersController(ILogger<ChampionsController> logger, IHttpClientFactory clientFactory)
        {
            _logger = logger;
            _client = clientFactory.CreateClient(Constants.ApiService.name);
        }

        // GET: api/lol/players
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            route = "tournaments/" + 2378.ToString() + "/players";
            var resp = await _client.GetAsync(Constants.LeagueOfLegends.route + "/" + route);
            var content = await resp.Content.ReadAsStringAsync();

            Debug.WriteLine(content);

            if (!resp.IsSuccessStatusCode)
            {
                return Ok(new
                {
                    fat = "I'm fat"
                });
            }

            return Ok(new
            {
                data = content
            });
        }
    }
}