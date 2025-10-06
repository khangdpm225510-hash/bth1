using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225490__Nguyen_Thi_Huynh_Tran__MyWorld10_SmartHome
{
    public class MusicSystem
    {
        public void Play(string playlist) => Console.WriteLine($"Phát playlist: {playlist}");
        public void Stop() => Console.WriteLine("Dừng phát nhạc");
    }
}
