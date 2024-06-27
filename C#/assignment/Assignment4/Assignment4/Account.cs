using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Account
{
    public class insufficientBalanceException : Exception
    {
        public insufficientBalanceException()
        {
            Console.WriteLine("Insufficient balance");
        }
    }
    class Account
    {
        long accountNo;
        string customerName;
        string accountType;
        public static int transactionType;
        public static int amount;
        public static int balance;

        public Account()
        {
            accountNo = 3456789098;
            customerName = "Raghu";
            accountType = "Savings";
            Console.WriteLine($"Account no is {accountNo} Customer name is {customerName} Account type is {accountType}");

        }
        public static void getData()
        {
            Console.WriteLine("enter 1 for deposit 2 for withdraw");
            transactionType = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter amount");
            amount = Convert.ToInt32(Console.ReadLine());
        }
        public static void Balance()
        {
            balance = Convert.ToInt32(Console.ReadLine());
            if (balance < 0)
            {
                throw new ArgumentException("your account has insufficient balance");
            }
        }
        public static void credit()
        {
            if (transactionType == 1)
            {
                balance += amount;
            }
        }
        public static void debit()
        {
            if (transactionType == 2)
            {
                balance -= amount;
            }
            else
            {
                Console.WriteLine("invalid");
            }
        }
        public static void show()
        {
            Console.WriteLine($"after deposit/ withdraw your balance is {balance} ");
        }


        static void Main(string[] args)
        {
            try
            {
                Balance();
            }
            catch (insufficientBalanceException ex)
            {
                Console.WriteLine($"error: {ex.Message}");
            }
            show();
            Console.Read();
        }
    }
}
