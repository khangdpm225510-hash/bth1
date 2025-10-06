using System;

namespace Optimized.Folder
{
    public class SilverState : Statee
    {
        public SilverState(double balance, Account account)
        {
            this.Balance = balance;
            this.Account = account;
            this.lowerLimit = 0;
            this.upperLimit = 1000;
            this.interest = 0.02;  // Interest rate for Silver state
        }

        public override void Deposit(double amount)
        {
            Balance += amount;
            if (Balance > upperLimit)
            {
                Account.State = new GoldState(Balance, Account);
            }
        }

        public override void Withdraw(double amount)
        {
            Balance -= amount;
            if (Balance < lowerLimit)
            {
                // Overdraft or move to a different state if needed
                Console.WriteLine("Warning: You have overdrafted your account.");
            }
        }

        public override void PayInterest()
        {
            Balance += Balance * interest;
        }
    }
}
