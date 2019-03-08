using System;

namespace LetterSizes_TC
{
    class A0Paper
    {
        public static string CanBuild(int[] A)
        {
            double canDo = 1;
            double check = 0;
            //A0 = 1
            //A1 = .5
            //A2 = .25
            if (A[0] > 0)
            {
                return "Possible";
            }
            else
            {
                for (int i = 1; i < A.Length; i++)
                {
                    //   0  =   0   + ( 4*(1/(2*2)))
                    double tmp = 1 / (Convert.ToDouble(i) * 2);
                    check = check + (A[i] * tmp);
                    Console.WriteLine("tmp " + tmp);
                    Console.WriteLine("A[i] " + A[i]);
                    Console.WriteLine("check " + check);
                }
                if (check >= canDo)
                {
                    return "Possible";
                }
                return "Impossible";
            }
        }
    }
}


