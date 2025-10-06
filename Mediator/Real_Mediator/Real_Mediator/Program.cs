using System;

namespace Real_Mediator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
            Chatroom chatroom = new Chatroom();

            
            Participant George = new Beatle("George");
            Participant Paul = new Beatle("Paul");
            Participant Ringo = new Beatle("Ringo");
            Participant John = new Beatle("John");
            Participant Yoko = new NonBeatle("Yoko");

            chatroom.Register(George);
            chatroom.Register(Paul);
            chatroom.Register(Ringo);
            chatroom.Register(John);
            chatroom.Register(Yoko);

           
            Yoko.Send("John", "Xin chào John!");
            Paul.Send("Ringo", "Tinh yeu la tat ca");
            Ringo.Send("George", "Chua ngot ngao cua toi");
            Paul.Send("John", "Khong the mua duoc tinh yeu");
            John.Send("Yoko", "Tinh yeu ngot ngao cua toi");

            Console.ReadKey();
        }
    }
}
