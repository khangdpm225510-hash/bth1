using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myworld_Command
{
    public class Television
    {
        private bool isOn = false;
        private int volume = 10;
        private int channel = 1;

        public void Operation(string action)
        {
            switch (action)
            {
                case "ON":
                    isOn = true;
                    Console.WriteLine("TV is ON");
                    break;
                case "OFF":
                    isOn = false;
                    Console.WriteLine("TV is OFF");
                    break;
                case "VOLUME_UP":
                    if (isOn) { volume++; Console.WriteLine("Volume = " + volume); }
                    break;
                case "VOLUME_DOWN":
                    if (isOn && volume > 0) { volume--; Console.WriteLine("Volume = " + volume); }
                    break;
                case "CHANNEL_UP":
                    if (isOn) { channel++; Console.WriteLine("Channel = " + channel); }
                    break;
                case "CHANNEL_DOWN":
                    if (isOn && channel > 1) { channel--; Console.WriteLine("Channel = " + channel); }
                    break;
            }
        }
    }
}
