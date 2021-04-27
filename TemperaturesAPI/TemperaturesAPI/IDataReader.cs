using System.Collections.Generic;
using System.Threading.Tasks;

namespace TemperaturesAPI
{
    public interface IDataReader
    {
        Task<List<TemperatureModel>> GetData();
    }
}