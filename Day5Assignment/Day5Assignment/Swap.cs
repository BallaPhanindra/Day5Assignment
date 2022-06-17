using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Assignment
{
    internal class Swap
    {
        public void SwapNums()
        {
            int a = 3;
            int b = 6;

            int temp;
            temp = b;
            b = a;
            a = temp;

            Console.WriteLine("Swapped numbers are "+a+" "+b);
        }
    }
}
