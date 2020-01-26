using System;

namespace _4.EqualPairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int value1 = 0;
            int value2 = 0;
            int diff = 0;
            int maxDiff = 0;

            for (int i = 0; i <= n; i++)
            {
                value2 = value1;
                value1 = 0;
                value1 += int.Parse(Console.ReadLine());
                value1 += int.Parse(Console.ReadLine());
               
                if (i != 0)
                {
                    diff = Math.Abs(value1 - value2);
                    if (diff != 0 && diff > maxDiff)
                    {
                        maxDiff = diff;
                    }
                }
           }
            if (value2 == value1 || n == 1)
            {
                Console.WriteLine("Yes, value=" + value1);

            }
            else
            {
            
                Console.WriteLine("No, maxdiff=" + maxDiff);
            }
        }
    }
}
