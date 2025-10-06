using System;

namespace Myworld_Command   // 🔹 đổi Real_Command thành Myworld_Command
{
    public class Program
    {
        public static void Main(string[] args)
        {
            RemoteControl remote = new RemoteControl();

            // bật TV
            remote.ExecuteCommand(new TvCommand(new Television(), "ON"));
            remote.ExecuteCommand(new TvCommand(new Television(), "VOLUME_UP"));
            remote.ExecuteCommand(new TvCommand(new Television(), "CHANNEL_UP"));
            remote.ExecuteCommand(new TvCommand(new Television(), "OFF"));

            remote.Undo(3);
            remote.Redo(2);

            Console.ReadKey();
        }
    }
}
