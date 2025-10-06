using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myworld_obsever
{
    public class LEDDisplay : IDisplay
    {
        private string _location;

        public LEDDisplay(string location)
        {
            _location = location;
        }

        public void Update(WeatherData data)
        {
            Console.WriteLine($"💡 {_location}: Nhiệt độ hiện tại = {data.Temperature}°C");
        }
    }
}
