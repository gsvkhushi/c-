namespace exceptionhandling
{

    using System;

    public class InsufficientFundsException : Exception
    {
        public InsufficientFundsException(string message) : base(message)
        {
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            decimal balance = 5000m;  // Initialize balance
            Console.WriteLine($"Initial balance: {balance:C}");

            Console.Write("Enter withdrawal amount: ");
            string input = Console.ReadLine();

            try
            {
                decimal withdrawalAmount = decimal.Parse(input);  // Parse input

                if (withdrawalAmount > balance)                   // Check funds
                {
                    throw new InsufficientFundsException("Insufficient funds for this withdrawal.");
                }

                balance -= withdrawalAmount;                       // Update balance
                Console.WriteLine($"Withdrawal successful. New balance: {balance:C}");
            }
            catch (InsufficientFundsException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");        // Handle insufficient funds
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a numeric value.");  // Handle bad input
            }
        }

    }
    }
