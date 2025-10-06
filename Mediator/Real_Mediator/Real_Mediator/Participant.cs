using System;

namespace Real_Mediator
{
    public class Participant
    {
        public string Name { get; }
        public Chatroom Chatroom { get; set; }

        public Participant(string name)
        {
            Name = name;
        }

        public void Send(string to, string message)
        {
            Chatroom.Send(Name, to, message);
        }

        public virtual void Receive(string from, string message)
        {
            Console.WriteLine("{0} gui den {1}: '{2}'", from, Name, message);
        }
    }
}
