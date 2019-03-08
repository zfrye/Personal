using System;

namespace LetterSizes_TC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A");
            int[] A = { 0, 3 };
            Console.WriteLine(A0Paper.CanBuild(A));
            Console.WriteLine("-----------");
            Console.WriteLine("B");
            int[] B = { 0,1,2};
            Console.WriteLine(A0Paper.CanBuild(B));
            Console.WriteLine("-----------");
            Console.WriteLine("C");
            int[] C = { 0, 0, 0, 0, 15 };
            Console.WriteLine(A0Paper.CanBuild(C));
            Console.WriteLine("-----------");
            Console.WriteLine("D");
            int[] D = { 2, 0, 0, 0, 0, 0, 0, 3, 2, 0, 0, 5, 0, 3, 0, 0, 1, 0, 0, 0, 5 };
            Console.WriteLine(A0Paper.CanBuild(D));
        }
    }
}
