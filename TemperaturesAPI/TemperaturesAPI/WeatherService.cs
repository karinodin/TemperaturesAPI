using System.Collections.Generic;
using System.Linq;
using TemperaturesAPI;

namespace TemperaturesAPI
{
    public class WeatherService : IWeatherService
    {

        public double MaxTemperature(List<TemperatureModel> temperatureModels)
        {
            return temperatureModels.Select(x => x.Temperature).Max();
        }

        public double MinTemperature(List<TemperatureModel> temperatureModels)
        {
            return temperatureModels.Select(x => x.Temperature).Min();
        }

        public double AverageTemperature(List<TemperatureModel> temperatureModels)
        {
            return temperatureModels.Select(x => x.Temperature).Average();
        }
    }
}