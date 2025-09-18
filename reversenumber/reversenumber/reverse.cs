using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reversenumber
{
    internal class reverse
    {
        int num;
        int rev = 0;
        int temp;
        public reverse(int num)
        {
            this.num = num;
        }
        public void process()
        {
            while (num > 0)
            {
                temp = num % 10;
                num /= 10;
                rev = rev * 10 + temp;
            }

        }
        public void display()
        {
            Console.WriteLine($"The Reversed Number is {rev}");
        }
    }
}
