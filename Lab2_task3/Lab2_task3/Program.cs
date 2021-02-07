using System;

namespace Lab2_task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum1 = 0, sum2 = 0;

            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    sum1 = sum1 + i;
                }
                else
                {
                    sum2 = sum2 + i;
                }
            }
            Console.WriteLine("Sum of odd number (1-100): " + sum2);
            Console.WriteLine("Sum of even number(1-100) : " + sum1);
            Console.WriteLine();
           
        }
    }
}
