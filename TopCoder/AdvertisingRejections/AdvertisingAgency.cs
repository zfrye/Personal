using System;
using System.Collections.Generic;
using System.Text;

namespace AdvertisingAgency_TC
{
    class AdvertisingAgency
    {

        public static int numberOfRejections(int[] boards)
        {
            int rejections = 0;
            List<int> taken = new List<int>();
            foreach(int i in boards)
            {
                if (taken.Contains(i))
                {
                    rejections++;
                }
                else
                {
                    taken.Add(i);
                }
            }

            return rejections;
        }
    }
}
