using CryptoCurrency.Client;
using CryptoCurrency.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CryptoCurrency.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IRapidClient _rapidClient;

        public HomeController(ILogger<HomeController> logger, IRapidClient rapidClient)
        {
            _logger = logger;
            _rapidClient = rapidClient;
        }
        [HttpGet]
        public async Task<JsonResult> Get()
        {
            var result = await _rapidClient.GetAsync();
            return new JsonResult(result);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
