using System.Collections.Generic;

namespace Real_Mediator
{
    public class Chatroom : AbstractChatroom
    {
        private readonly Dictionary<string, Participant> participants = new();

        public override void Register(Participant participant)
        {
            if (!participants.ContainsValue(participant))
            {
                participants[participant.Name] = participant;
            }
            participant.Chatroom = this;
        }

        public override void Send(string from, string to, string message)
        {
            if (participants.TryGetValue(to, out Participant participant))
            {
                participant.Receive(from, message);
            }
        }
    }
}
