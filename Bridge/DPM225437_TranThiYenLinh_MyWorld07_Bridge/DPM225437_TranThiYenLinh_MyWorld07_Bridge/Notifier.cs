using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225437_TranThiYenLinh_MyWorld07_Bridge
{
    public abstract class Notifier
    {
        public IChannel Channel { get; set; }
        public abstract void Notify(string message);
    }

    public class ReservationNotifier : Notifier
    {
        public override void Notify(string message)
        {
            Channel?.Send(message);
        }
    }
}
