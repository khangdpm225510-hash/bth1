using System;
using System.IO;

namespace Real13_ChainOfResponsibility
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Setup Chain of Responsibility
            Approver larry = new Director();
            Approver sam = new VicePresident();
            Approver tammy = new President();

            larry.SetSuccessor(sam);
            sam.SetSuccessor(tammy);

            // Generate and process purchase requests
            Purchase p1 = new Purchase(2034, 350.00, "Supplies");
            larry.ProcessRequest(p1);

            Purchase p2 = new Purchase(2035, 32590.10, "Project X");
            larry.ProcessRequest(p2);

            Purchase p3 = new Purchase(2036, 122100.00, "Project Y");
            larry.ProcessRequest(p3);

            Console.ReadKey();
        }
    }
}
