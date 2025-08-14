using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankacc
{
    class Bankacc
    {
        public double Balance;

        public void Deposit(double amt)
        {
            Balance += amt;
            Console.WriteLine("Deposited" + amt);
        }
        public void withdraw(double amt)
        {
            if (amt <= Balance)
            {
                Balance -= amt;

                Console.WriteLine("withdrawan:" + amt);
            }
            else
                Console.WriteLine("Not enough balance");
        }
    }
    class SavingAcc : Bankacc
    {
        public double Intrestrate;

        public void CalculateIntrest()

        {
            Console.WriteLine("Intrest:" + (Balance * Intrestrate / 100));
        }

    }
}

    

