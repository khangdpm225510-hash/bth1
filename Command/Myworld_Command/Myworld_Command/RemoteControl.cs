using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myworld_Command
{
    public class RemoteControl
    {
        private List<Command> commands = new List<Command>();
        private int current = 0;

        public void ExecuteCommand(Command command)
        {
            command.Execute();
            commands.Add(command);
            current++;
        }

        public void Undo(int levels)
        {
            Console.WriteLine("\n---- Undo {0} actions ----", levels);
            for (int i = 0; i < levels; i++)
            {
                if (current > 0)
                {
                    Command command = commands[--current];
                    command.UnExecute();
                }
            }
        }

        public void Redo(int levels)
        {
            Console.WriteLine("\n---- Redo {0} actions ----", levels);
            for (int i = 0; i < levels; i++)
            {
                if (current < commands.Count)
                {
                    Command command = commands[current++];
                    command.Execute();
                }
            }
        }
    }
}
