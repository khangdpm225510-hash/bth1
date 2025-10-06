using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myworld_Command
{
    public class TvCommand : Command
    {
        private Television tv;
        private string action;

        public TvCommand(Television tv, string action)
        {
            this.tv = tv;
            this.action = action;
        }

        public override void Execute()
        {
            tv.Operation(action);
        }

        public override void UnExecute()
        {
            tv.Operation(Undo(action));
        }

        private string Undo(string action)
        {
            switch (action)
            {
                case "ON": return "OFF";
                case "OFF": return "ON";
                case "VOLUME_UP": return "VOLUME_DOWN";
                case "VOLUME_DOWN": return "VOLUME_UP";
                case "CHANNEL_UP": return "CHANNEL_DOWN";
                case "CHANNEL_DOWN": return "CHANNEL_UP";
                default: throw new ArgumentException("Unknown action");
            }
        }
    }
}
