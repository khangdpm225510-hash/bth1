using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myworld_obsever
{
    public interface IDisplay
    {
        void Update(WeatherData data);
    }
}
