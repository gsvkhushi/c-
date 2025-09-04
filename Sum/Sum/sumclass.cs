using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Sum
{
    public class sum
    {
        public int Number;
        public int DigitSum;

        public void ReadNumber()
        {
            Console.Write("Enter a number:");
            Number = Convert.ToInt32(Console.ReadLine());
        }
        public void calculatesum()
        {
            int temp = Number;
            DigitSum = 0;

            while (temp != 0)
            {
                int digit = temp % 10;
                DigitSum += digit;
                temp /= 10;

            }

        }
        public void display()
        {
            Console.WriteLine("sum of digits :" + DigitSum);
        }
    }
}