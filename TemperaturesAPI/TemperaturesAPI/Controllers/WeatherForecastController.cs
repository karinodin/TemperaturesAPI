using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TemperaturesAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IDataReader _dataReader;
        private readonly IWeatherService _weatherService;

        public WeatherForecastController(IDataReader dataReader, IWeatherService weatherService)
        {
            _dataReader = dataReader;
            _weatherService = weatherService;
        }

        [HttpGet("Dataset")]
        public async Task<IActionResult> GetTemperatures()
        {
            var result = await _dataReader.GetData();
            return Ok(result);
        }

        [HttpGet("Analytics")]
        public async Task<IActionResult> GetWeatherData()
        {
            var temperatureModels = await _dataReader.GetData(); 
            var viewModel = new TemperatureViewModel
            {
                MaxTemperature = _weatherService.MaxTemperature(temperatureModels),
                MinTemperature = _weatherService.MinTemperature(temperatureModels),
                AverageTemperature = _weatherService.AverageTemperature(temperatureModels)
            };

            return Ok(viewModel);
        }

        [HttpGet("HighestTemperature")]
        public async Task<IActionResult> GetHighestTemperature()
        {
            var result = _weatherService.MaxTemperature(await _dataReader.GetData());
            return Ok(result);
        }
        
        [HttpGet("LowestTemperature")]
        public async Task<IActionResult> GetLowestTemperature()
        {
            var result = _weatherService.MinTemperature(await _dataReader.GetData());
            return Ok(result);
        }
        
        [HttpGet("AverageTemperature")]
        public async Task<IActionResult> GetAverageTemperature()
        {
            var result = _weatherService.AverageTemperature(await _dataReader.GetData());
            return Ok(result);
        }
    }
}