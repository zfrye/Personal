using System;
using System.Collections.Generic;
using System.Text;

namespace _7DigitInterpreter_TC
{
    class CheckFunction
    {
        private static readonly Dictionary<char, int> dict =
            new Dictionary<char, int>
            {
                {'0',6 },
                {'1',2 },
                {'2',5 },
                {'3',5 },
                {'4',4 },
                {'5',5 },
                {'6',6 },
                {'7',3 },
                {'8',7 },
                {'9',6 }
            };

        public static int newFunction(string str)
        {
            int toReturn = 0;

            foreach (char c in str)
            {
                foreach (var item in dict)
                {
                    if(item.Key == c)
                    {
                        //Console.WriteLine("key" + item.Key + " " + item.Value);
                        toReturn += item.Value;
                        break;
                    }
                }
            }
            return toReturn;
        }


    }
}
