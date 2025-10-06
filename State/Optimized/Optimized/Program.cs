using System;
using Optimized.Folder;
using static System.Console;

namespace Optimized
{
    public class Program
    {
        // Phương thức Main được gọi khi chương trình bắt đầu
        static void Main(string[] args)
        {
            // Khởi tạo tài khoản với chủ sở hữu là "John Doe"
            Account account = new Account("John Doe");

            // Hiển thị trạng thái ban đầu của tài khoản
            WriteLine($"Account Owner: {account.Owner}");
            WriteLine($"Initial Balance: {account.Balance:C}");
            WriteLine($"Current State: {account.State.GetType().Name}");
            WriteLine();

            // Gửi tiền vào tài khoản và kiểm tra chuyển trạng thái
            account.Deposit(500);  // Gửi tiền vào tài khoản
            account.Deposit(600);  // Số dư vượt quá giới hạn, sẽ chuyển sang trạng thái Gold

            // Rút tiền và kiểm tra số dư
            account.Withdraw(200); // Rút tiền khỏi tài khoản

            // Tính lãi suất
            account.PayInterest();
            WriteLine($"Balance after interest: {account.Balance:C}");
            WriteLine($"Current State: {account.State.GetType().Name}");
        }
    }
}
