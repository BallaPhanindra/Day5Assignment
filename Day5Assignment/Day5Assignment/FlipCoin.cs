using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Assignment
{
    internal class FlipCoin
    {
        public void Flip()
        {
            Random random = new Random();
            int a=random.Next(0,2);

            if (a == 0)
            {
                Console.WriteLine("Outcome is Tails");
            }
            else
            {
                Console.WriteLine("Outcome is Heads");
            }
        }
    }
}
