using System;

class Program
{
    static void Main()
    {
        int[] arrSource = new int[4];
        arrSource[0] = 1;
        arrSource[1] = 2;
        arrSource[2] = 3;
        arrSource[3] = 4;

        int[] arrTarget = new int[2];

        Array.Copy(arrSource, arrTarget, 2);

        Console.WriteLine("Destination Array ...");
        foreach (int value in arrTarget)
        {
            Console.WriteLine(value);
        }
    }
}