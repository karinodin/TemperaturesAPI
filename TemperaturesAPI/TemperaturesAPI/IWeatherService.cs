using System.Collections.Generic;

namespace TemperaturesAPI
{
    public interface IWeatherService
    {
        double MaxTemperature(List<TemperatureModel> temperatureModels);
        double MinTemperature(List<TemperatureModel> temperatureModels);
        double AverageTemperature(List<TemperatureModel> temperatureModels);
    }
}