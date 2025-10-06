using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWorld2
{
    class MainApp
    {
        public static void Main()
        {
            // Tạo công ty du lịch (Director)
            TravelAgency agency = new TravelAgency();

            // Xây dựng tour cơ bản
            TourBuilder basicBuilder = new BasicTourBuilder();
            agency.Construct(basicBuilder);
            basicBuilder.Tour.Show();

            // Xây dựng tour cao cấp
            TourBuilder luxuryBuilder = new LuxuryTourBuilder();
            agency.Construct(luxuryBuilder);
            luxuryBuilder.Tour.Show();

            Console.ReadKey();
        }
    }

}
