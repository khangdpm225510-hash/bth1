using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225437_TranThiYenLinh_MyWorld07_Bridge
{
    public class EmailChannel : IChannel
    {
        public void Send(string message)
        {
            Console.WriteLine($"Email sent: {message}");
        }
    }
}
