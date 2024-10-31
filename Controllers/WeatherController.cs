using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WeatherNow.Services;

namespace WeatherNow.Controllers
{
    public class WeatherController : Controller
    {

        private readonly WeatherService _weatherService;

        public WeatherController(WeatherService weatherService)
        {
            _weatherService = weatherService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> GetWeather(string city)
        {
            var weatherData = await _weatherService.GetWeatherAsync(city);
            return View("Index", weatherData);
        }

    }
}