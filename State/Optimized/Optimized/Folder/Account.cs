using System;

namespace Optimized.Folder
{
    public class Account
    {
        private readonly string owner;

        // Constructor
        public Account(string owner)
        {
            this.owner = owner;
            this.State = new SilverState(0.0, this);  // Trạng thái mặc định là Silver
        }

        // Gets the balance
        public double Balance
        {
            get { return State.Balance; }
        }

        // Gets or sets state
        public Statee State { get; set; }

        public string Owner => owner;

        public void Deposit(double amount)
        {
            State.Deposit(amount);
            Console.WriteLine($"Deposited {amount:C}");
            Console.WriteLine($"Current Balance: {Balance:C}");
            Console.WriteLine($"Current State: {State.GetType().Name}");
            Console.WriteLine();
        }

        public void Withdraw(double amount)
        {
            State.Withdraw(amount);
            Console.WriteLine($"Withdrew {amount:C}");
            Console.WriteLine($"Current Balance: {Balance:C}");
            Console.WriteLine($"Current State: {State.GetType().Name}");
            Console.WriteLine();
        }

        public void PayInterest()
        {
            State.PayInterest();
            Console.WriteLine("Interest Paid.");
            Console.WriteLine($"Current Balance: {Balance:C}");
            Console.WriteLine($"Current State: {State.GetType().Name}");
            Console.WriteLine();
        }
    }
}
