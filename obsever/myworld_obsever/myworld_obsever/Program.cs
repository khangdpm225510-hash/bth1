using myworld_obsever;
using System;
using System.Collections.Generic;

namespace myworld_observer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            WeatherStation station = new WeatherStation(30.0);

            station.Attach(new PhoneDisplay("Điện thoại A"));
            station.Attach(new LEDDisplay("Màn hình LED ngoài trời"));

            station.Temperature = 31.5;
            station.Temperature = 28.3;
            station.Temperature = 33.0;

            Console.ReadKey();
        }
    }
}