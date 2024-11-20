using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Total_Amount_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Taking input from the user
            Console.WriteLine("Enter the deposit amount:");
            double amount = double.Parse(Console.ReadLine());
            Console.WriteLine("Choose a savings option:");
            Console.WriteLine("1: 5 years fixed deposit (10% interest rate)");
            Console.WriteLine("2: Monthly interest (8.5% annual interest rate)");
            int option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    // Option 1: 5 years fixed deposit with 10% interest rate
                    double interestRate1 = 0.10;
                    double totalAmount = amount * Math.Pow(1 + interestRate1, 5);
                    Console.WriteLine("Total amount after 5 years with 10% interest: {0:C}", totalAmount);
                    break;

                case 2:
                    // Option 2: Monthly interest with 8.5% annual interest rate
                    double annualInterestRate = 0.085;
                    double monthlyInterestRate = annualInterestRate / 12; // Convert annual rate to monthly
                    double monthlyInterestAmount = amount * monthlyInterestRate;
                    Console.WriteLine("Monthly interest amount with 8.5% annual interest: {0:C}", monthlyInterestAmount);
                    break;

                default:
                    Console.WriteLine("Invalid option selected. Please choose 1 or 2.");
                    break;
            }
        }
    }
}
