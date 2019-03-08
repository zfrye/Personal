using System;
using System.Text.RegularExpressions;

namespace Decompressing_0._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("String Decompression");
            Console.WriteLine("**MUST be lowercase");
            Console.WriteLine("i.e. 9[a] => aaaaaaaaa");
            Console.WriteLine();
            decom(Console.ReadLine());

        }
        private static void decom(string str)
        {
            Console.WriteLine();
            string patternCenter = @"(\d*) ?\[ ?([a-z ]*) ?\] ?";
            if(Regex.IsMatch(str, patternCenter))
            {
                string temp = "";
                String replace = "";
                int repeat = 0;
                Match match = Regex.Match(str, patternCenter);
                repeat = Convert.ToInt32(match.Groups[1].Value);
                temp = match.Groups[2].Value;
                Console.WriteLine("System: Fixing " + str + "\n r: " + repeat + "\n t: " + temp);
                for (int i =0; i<repeat; i++)
                {
                    replace = replace + temp;
                }
                str = Regex.Replace(str, patternCenter, replace);
                decom(str);
            }
            else
            {
                Console.WriteLine(str);
            }
        }
    }
}

//string patternRepeat = @"( ?(\d*) ?\[)";
//string patternContent = @"( ?\[ ?(\w) ?\] ?)";
