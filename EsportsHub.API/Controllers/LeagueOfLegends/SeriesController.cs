using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using Microsoft.Extensions.Logging;
using EsportsHub.API.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Diagnostics;

namespace EsportsHub.API.Controllers.LeagueOfLegends
{
    [Route("api/lol/[controller]")]
    [ApiController]
    public class SeriesController : ControllerBase
    {
        private readonly ILogger<ChampionsController> _logger;
        private readonly HttpClient _client;

        private readonly string route = "series";

        public SeriesController(ILogger<ChampionsController> logger, IHttpClientFactory clientFactory)
        {
            _logger = logger;
            _client = clientFactory.CreateClient(Constants.ApiService.name);
        }

        // GET: api/lol/champions
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var resp = await _client.GetAsync(Constants.LeagueOfLegends.route + "/" + route);
            var content = await resp.Content.ReadAsStringAsync();

            if (!resp.IsSuccessStatusCode)
            {
                return NotFound();
            }

            return Ok(new
            {
                draw = 1,
                recordsTotal = 2,
                recordsFiltered = 3,
                data = content
            });
        }
    }
}