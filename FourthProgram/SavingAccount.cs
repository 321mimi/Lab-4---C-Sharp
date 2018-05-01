using System;

namespace FourthProgram
{
    class SavingAccount
    {
        // Properties
        public int AccountNumber;
        public string Owner;
        public double Balance;
        public double MonthlyDeposit;

        // Constructor
        public SavingAccount(string owner, double startingBalance, double userMonthlyDeposit)
        {
            Random rnd = new Random();
            AccountNumber = rnd.Next(90000, 99999);

            Owner = owner;

            Balance = startingBalance;

            MonthlyDeposit = userMonthlyDeposit;
        }

        // Static properties
        public static double MonthlyFee = 4.0;
        public static double MonthlyInterestRate = 0.0025;
        public static double MinimumInitialBalance = 1000;
        public static double MinimumMonthlyDeposit = 50;

        public void AccountBalance(int m)
        {
            for (int n = 0; n < m; n++)
            {
                double interest = (Balance - MonthlyFee) * MonthlyInterestRate;
                Balance = (Balance - MonthlyFee) + interest + MonthlyDeposit;
            }
        }

        // Methods
        // Deposit
        public void Deposit(double amount)
        {
            Balance += amount;
        }
        // Withdraw
        public void Withdraw(double amount)
        {
            Balance -= amount;
        }

    }
}
