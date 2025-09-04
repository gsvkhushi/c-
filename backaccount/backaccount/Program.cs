namespace backaccount
{
   
class Program
        {
            static void Main(string[] args)
            {
                SavingAcc mySavings = new SavingAcc();
                mySavings.Balance = 1000;
                mySavings.Intrestrate = 5;
                mySavings.Deposit(500);
                mySavings.withdraw(200);
                mySavings.CalculateIntrest();
                Console.WriteLine("Final Balance: " + mySavings.Balance);
                Console.ReadLine();
            }
        }

    }

