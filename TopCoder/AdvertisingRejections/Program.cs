using System;
namespace AdvertisingAgency_TC
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] toGo = { 1, 2, 1, 2 };

            Console.WriteLine(AdvertisingAgency.numberOfRejections(toGo));
        }
    }
}
