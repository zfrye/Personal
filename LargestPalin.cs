using System;
using System.Linq;

namespace Palin
{
    class Program
    {
        private static long lowerbound = 0L;
        private static long maxPalin = 0L;

        static void Main(string[] args)
        {
            lowerbound = 5000000L;

            Find();

        }

        private static bool IsPalin(long i)
        {
            string str = i.ToString();
            return str.SequenceEqual(str.Reverse());
        }

        private static void Find()
        {
            for (long i = 9999999; i >= (lowerbound); i--)
            {
                for (long k = i; k >= 1000000; k--)
                {
                    if (i * k > maxPalin && IsPalin(i * k))
                    {
                        maxPalin = i * k;
                        Console.WriteLine("System: " + maxPalin);
                        Console.WriteLine("Tracker: i = " + i + ", lower = " + lowerbound);
                        lowerbound = k + 1;
                    }
                }
            }
            Console.WriteLine("System: Done.");
        }
    }
}
