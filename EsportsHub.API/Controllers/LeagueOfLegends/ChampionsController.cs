using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using Microsoft.Extensions.Logging;


namespace EsportsHub.API.Controllers.LeagueOfLegends
{
    [Route("api/lol/[controller]")]
    [ApiController]
    public class ChampionsController : ControllerBase
    {
        private readonly ILogger<ChampionsController> _logger;
        private readonly HttpClient _client;

        private readonly string route = "series";

        public ChampionsController(ILogger<ChampionsController> logger, IHttpClientFactory clientFactory)
        {
            _logger = logger;
            _client = clientFactory.CreateClient(Constants.ApiService.name);
        }

        // GET: api/lol/champions
        [HttpGet]
        public async Task<string> Get()
        {
            var resp = await _client.GetAsync(Constants.LeagueOfLegends.route + "/" + route);

            return await resp.Content.ReadAsStringAsync();
        }
    }
}