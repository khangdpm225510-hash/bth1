using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWorld01
{
    class MainApp
    {
        public static void Main()
        {
            // Sản xuất xe điện (EV)
            VehicleFactory evFactory = new EVFactory();
            VehicleClient evClient = new VehicleClient(evFactory);
            evClient.Run();

            // Sản xuất xe xăng (ICE)
            VehicleFactory iceFactory = new ICEFactory();
            VehicleClient iceClient = new VehicleClient(iceFactory);
            iceClient.Run();

            Console.ReadKey();
        }
    }
}
