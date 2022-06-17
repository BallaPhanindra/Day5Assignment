using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Assignment
{
    internal class PowOf2
    {
        public void PowerOf2()
        {
            {
                Console.WriteLine("Please enter N value");
                int N=Int32.Parse(Console.ReadLine());

                for(int i=0;i<=N;i++)
                {
                    int x = 2 * 1;
                    Console.WriteLine(2+" * "+i+" = "+x);
                }
            }
        }
    }
}
