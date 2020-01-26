using System;

namespace _13.For_cycle
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int num = 0; num <= 1000; num++)
            {
                if (num % 10 == 7)
                {
                    Console.WriteLine(num);
                }
            }
        }
    }
}
