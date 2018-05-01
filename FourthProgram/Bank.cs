using System;
using System.Collections.Generic;

namespace FourthProgram
{
    class Bank
    {
        static List<SavingAccount> accounts = new List<SavingAccount>();
        static void Main(string[] args)
        {
            // Name
            string name = "";
            do
            {
                Console.Write("Enter customer name: ");
                name = Console.ReadLine();
                if (name != "")
                {
                    // Initial deposit
                    string initialDepositString = "";
                    double userInitialDeposit = 0;
                    do
                    {
                        Console.Write("Enter " + name + "'s Initial Deposit Amount (minimum $" + SavingAccount.MinimumInitialBalance + "): ");
                        initialDepositString = Console.ReadLine();
                        try
                        {
                            userInitialDeposit = double.Parse(initialDepositString);
                            if (userInitialDeposit < SavingAccount.MinimumInitialBalance)
                            {
                                Console.WriteLine("\nThe number must be larger than 1000!\n");
                            }
                        }
                        catch
                        {
                            Console.Write("\nYou did not enter a number!\n\n");
                        }

                    } while (userInitialDeposit < SavingAccount.MinimumInitialBalance);


                    // Monthly deposit
                    string monthlyDepositString = "";
                    double userMonthlyDeposit = 0;
                    do
                    {
                        Console.Write("Enter " + name + "'s Monthly Deposit Amount (minimum $" + SavingAccount.MinimumMonthlyDeposit + "): ");
                        monthlyDepositString = Console.ReadLine();
                        try
                        {
                            userMonthlyDeposit = double.Parse(monthlyDepositString);

                            if (userMonthlyDeposit < SavingAccount.MinimumMonthlyDeposit)
                            {
                                Console.WriteLine("\nThe number must be bigger than 50!\n");
                            }
                        }
                        catch
                        {
                            Console.Write("\nYou did not enter a number!\n\n");
                        }
                    } while (userMonthlyDeposit < SavingAccount.MinimumMonthlyDeposit);

                    Console.Write("\n");

                    // Add account
                    SavingAccount account = new SavingAccount(name, userInitialDeposit, userMonthlyDeposit);
                    accounts.Add(account);
                }
                else
                {
                    if (accounts.Count < 1)
                    {
                        name = " ";
                        Console.WriteLine("You did not enter a name! ");
                    }
                }
            } while (name != "");


            for (int i = 0; i < accounts.Count; i++)
            {
                SavingAccount account = accounts[i];
                account.AccountBalance(6);
                Console.WriteLine("\nAfter 6 months, " + account.Owner + "'s account (#" + account.AccountNumber + "), has a balance of: " + account.Balance);
            }
            Console.ReadLine();
        }

    }
}