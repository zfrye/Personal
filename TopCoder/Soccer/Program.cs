using System;

namespace Soccer_TC
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] wins = { 12, 45, 20, 17, 48, 0 };
            int[] ties = { 48, 10, 53, 94, 0, 100 };
            Console.WriteLine(Soccer.maxPoints(wins, ties));
        }
    }
}
