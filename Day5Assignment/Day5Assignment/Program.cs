using System;

namespace Day5Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            FlipCoin f = new FlipCoin();
            f.Flip();

            LeapYear lp = new LeapYear();
            lp.CheckLeapYear();

            PowOf2 p2 = new PowOf2();
            p2.PowerOf2();

            HarmonicNum hm=new HarmonicNum();
            hm.nthHarmonic(4);

            PrimeFactor pm=new PrimeFactor();
            pm.PrimeFact();

            QuotientRem qm = new QuotientRem();
            qm.QuotRem();

            Swap s=new Swap();
            s.SwapNums();

            VowelConsonant vw = new VowelConsonant();
            vw.VowelOrConsonant('d');

            LargestOf3Nums ln = new LargestOf3Nums();
            ln.LargestOOf3();

        }
    }
}
