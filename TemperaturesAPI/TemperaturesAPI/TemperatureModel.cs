using System;

namespace TemperaturesAPI
{
    public class TemperatureModel
    {
        public int TimeStamp { get; init; }
        public DateTime DateTime{ get; init; }
        public double Temperature { get; init; }
    }
}