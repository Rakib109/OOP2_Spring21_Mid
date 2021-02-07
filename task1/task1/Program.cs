using System;

namespace Lab2_task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 100;
            for (int i = 0; i <= n; i += 2)
            {
                Console.WriteLine("the even numbers are:" + i);
            }
        }
    }
}