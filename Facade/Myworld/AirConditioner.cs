using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225490__Nguyen_Thi_Huynh_Tran__MyWorld10_SmartHome
{
    public class AirConditioner
    {
        public void SetTemperature(int temp) => Console.WriteLine($"Điều hòa chỉnh nhiệt độ {temp}°C");
        public void TurnOff() => Console.WriteLine("Điều hòa tắt");
    }
}
