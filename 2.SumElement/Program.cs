using System;

namespace _2.SumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int max = int.MinValue;

            for (int i = 0; i <n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (num > max)
                {
                    max = num;
                }
                sum += num;
            }
            sum = sum - max;
            if (sum == max)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = " + sum);
            }
            else
            {
                double diff = Math.Abs(sum - max);
                Console.WriteLine("No");
                Console.WriteLine("Diff = "+diff);
            }
        }
    }
}
