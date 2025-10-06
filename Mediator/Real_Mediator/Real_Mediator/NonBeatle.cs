using System;

namespace Real_Mediator
{
    public class NonBeatle : Participant
    {
        public NonBeatle(string name) : base(name) { }

        public override void Receive(string from, string message)
        {
            Console.Write("Gui den Non-Beatle: ");
            base.Receive(from, message);
        }
    }
}
