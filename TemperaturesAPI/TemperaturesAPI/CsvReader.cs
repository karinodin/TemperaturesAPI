using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace TemperaturesAPI
{
    public class CsvReader : IDataReader
    {
        private string _path;
        // Add constructor that takes source? 
        public CsvReader(string path)
        {
            _path = path;
        }

        public async Task<List<TemperatureModel>> GetData()
        {
            var file = File.ReadAllLines(_path);
            
            var temperatureData = new List<TemperatureModel>();

            foreach (var row in file)
            {
                var oneLine = row.Split(";");
                var timestamp = int.Parse(oneLine[0]);
                var temperature = double.Parse(oneLine[1]);
                var dateTime = DateTime.Parse(oneLine[2]);

                temperatureData.Add(new TemperatureModel
                {
                    DateTime = dateTime,
                    Temperature = temperature,
                    TimeStamp = timestamp
                });
            }

            return temperatureData;
        }
    }
}