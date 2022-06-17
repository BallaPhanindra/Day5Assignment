using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Assignment
{
    internal class LargestOf3Nums
    {
        public void LargestOOf3()
        {
            int a = 2;
            int b = 4;
            int c = 5;
            if (a > b && a > c)
            {
                Console.WriteLine(a+" is largest among given 3 nums");
            }
            else if(b>c&& b > a)
            {
                Console.WriteLine(b+ "is largest among given 3 nums");
            }
            else
            {
                Console.WriteLine(c+" is largest among given 3 nums");
            }
        }
    }
}
