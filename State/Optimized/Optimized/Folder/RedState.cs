using Optimized.Folder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
public class GoldState : Statee
{
    public GoldState(double balance, Account account)
    {
        this.Balance = balance;
        this.Account = account;
        this.lowerLimit = 0;
        this.upperLimit = 10000;
        this.interest = 0.05;  // Lãi suất cho Gold
    }

    public override void Deposit(double amount)
    {
        Balance += amount;
        if (Balance <= 1000)
        {
            Account.State = new SilverState(Balance, Account);  // Chuyển sang trạng thái Silver khi dưới 1000
        }
    }

    public override void Withdraw(double amount)
    {
        Balance -= amount;
        if (Balance < lowerLimit)
        {
            Console.WriteLine("Warning: You have overdrafted your account.");
        }
    }

    public override void PayInterest()
    {
        Balance += Balance * interest;
    }
}
