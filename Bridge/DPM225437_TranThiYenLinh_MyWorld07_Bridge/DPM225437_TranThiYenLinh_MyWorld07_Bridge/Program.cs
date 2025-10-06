using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225437_TranThiYenLinh_MyWorld07_Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            Notifier notifier = new ReservationNotifier();

            notifier.Channel = new EmailChannel();
            notifier.Notify("Bạn đã đặt bàn thành công cho 4 người lúc 19:00.");

            notifier.Channel = new SmsChannel();
            notifier.Notify("Reminder: Bàn của bạn lúc 19:00. Mã: 1234");

            Console.WriteLine("Done. Press any key...");
            Console.ReadKey();
        }
    }
}
