using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine("ATM Simulator");

        int balance = 1000;

        while (true)
        {
            Console.WriteLine("\n1 - Check Balance");
            Console.WriteLine("2 - Deposit Money");
            Console.WriteLine("3 - Withdraw Money");
            Console.WriteLine("4 - Exit");

            Console.Write("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                Console.WriteLine($"Your balance is ₱{balance}");
            }
            else if (choice == 2)
            {
                Console.Write("Enter the amount you want to deposit: ");
                int deposit = Convert.ToInt32(Console.ReadLine());
                balance += deposit;
                Console.WriteLine($"You have successfully deposited ₱{deposit}. Your new balance is ₱{balance}");
            }
            else if (choice == 3)
            {
                Console.Write("Enter the amount you want to withdraw: ");
                int withdraw = Convert.ToInt32(Console.ReadLine());

                if (withdraw > balance)
                {
                    Console.WriteLine("Insufficient funds!");
                }
                else
                {
                    balance -= withdraw;
                    Console.WriteLine($"You have successfully withdrawn ₱{withdraw}. Your new balance is ₱{balance}");
                }
            }
            else if (choice == 4)
            {
                Console.WriteLine("Thank you for using the ATM. Goodbye!");
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }
        }
    }
}