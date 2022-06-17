using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Assignment
{
    internal class QuotientRem
    {
        public void QuotRem()
        {
            Console.WriteLine("Please enter divisor and dividend");
            
            int divisor=Int32.Parse(Console.ReadLine());
            int dividend=Int32.Parse(Console.ReadLine());

            int quotient=divisor/dividend;
            Console.WriteLine(quotient);

            int remainder=divisor/dividend;
            Console.WriteLine(remainder);
        }
    }
}
