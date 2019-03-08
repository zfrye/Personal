using System;
using System.Collections.Generic;
using System.Text;

namespace Soccer_TC
{
    class Soccer
    {

        public static int maxPoints(int[] wins, int[] ties)
        {
            int maxTotal = 0;
            for(int i = 0; i < wins.Length; i++)
            {
                if (((wins[i] * 3) + (ties[i])) > maxTotal)
                {
                    maxTotal = (wins[i] * 3) + (ties[i]);
                }
            }
            return maxTotal;
        }
    }
}
