using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225490__Nguyen_Thi_Huynh_Tran__MyWorld10_SmartHome
{
    public class SmartHomeFacade
    {
        private LightSystem light;
        private SecuritySystem security;
        private AirConditioner ac;
        private MusicSystem music;

        public SmartHomeFacade()
        {
            light = new LightSystem();
            security = new SecuritySystem();
            ac = new AirConditioner();
            music = new MusicSystem();
        }

        // Kịch bản 1: Chủ nhà đi ra ngoài
        public void GoingOutMode()
        {
            Console.WriteLine("[SmartHome] Chế độ ra ngoài");
            light.TurnOff();
            ac.TurnOff();
            music.Stop();
            security.Activate();
        }

        // Kịch bản 2: Xem phim tại nhà
        public void MovieNightMode()
        {
            Console.WriteLine("[SmartHome] Chế độ xem phim");
            light.TurnOff();
            security.Deactivate();
            ac.SetTemperature(24);
            music.Play("Nhạc phim");
        }
    }
}
