using System;

namespace _5.Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            double p1 = 0;//do200
            double p2 = 0;//ot200do399
            double p3 = 0;//ot400do599
            double p4 = 0;//ot600do799
            double p5 = 0;//ot800+>

            for (int i = 1; i <=num; i++)
            {
                int inputNum = int.Parse(Console.ReadLine());

                if ( inputNum < 200)
                {
                    p1++;
                }
                else if (inputNum >= 200 && inputNum <= 399)
                {
                    p2++;
                }
                else if (inputNum >= 400 && inputNum <= 599)
                {
                    p3++;
                }
                else if (inputNum>=600&&inputNum<800)
                {
                    p4++;
                }
                else
                {
                    p5++;
                }
            }
            Console.WriteLine($"{p1 / num * 100:f2}%");
            Console.WriteLine($"{p2 / num * 100:f2}%");
            Console.WriteLine($"{p3 / num * 100:f2}%");
            Console.WriteLine($"{p4 / num * 100:f2}%");
            Console.WriteLine($"{p5 / num * 100:f2}%");
        }
    }
}
