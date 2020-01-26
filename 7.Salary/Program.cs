using System;

namespace _7.Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            int numTab = int.Parse(Console.ReadLine());
            double salary = double.Parse(Console.ReadLine());


            for (int i = 0; i <= numTab; i++)
            {
                string website = Console.ReadLine();
                if (website == "Facebook")
                {
                    salary -= 150;
                    if (salary <= 0)
                    {
                        Console.WriteLine($"You have lost your salary.");
                        break;
                    }
                }
                 else if (website == "Instagram")
                {
                    salary -= 100;
                    if (salary <= 0)
                    {
                        Console.WriteLine($"You have lost your salary.");
                        break;
                    }
                }
                else if (website == "Reddit")
                {
                    salary -= 50;
                    if (salary <= 0)
                    {
                        Console.WriteLine($"You have lost your salary.");
                        break;
                    }
                }
            }
            if (salary > 0)
            {
                Console.WriteLine(salary);
            }
        }
    }
}
