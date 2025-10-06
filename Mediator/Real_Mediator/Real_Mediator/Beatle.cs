using System;

namespace Real_Mediator
{
    public class Beatle : Participant
    {
        public Beatle(string name) : base(name) { }

        public override void Receive(string from, string message)
        {
            Console.Write("Gui den Beatle: ");
            base.Receive(from, message);
        }
    }
}
