using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myworld_obsever
{
    public class PhoneDisplay : IDisplay
    {
        private string _name;

        public PhoneDisplay(string name)
        {
            _name = name;
        }

        public void Update(WeatherData data)
        {
            Console.WriteLine($"📱 {_name} nhận thông báo: Nhiệt độ mới = {data.Temperature}°C");
        }
    }
}
