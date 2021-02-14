using System;
using System.Collections.Generic;
using System.Text;

class Program
{
	static void Main()
	{


		int[] source = new int[5];
		source[0] = 5;
		source[1] = 4;
		source[2] = 3;
		source[3] = 2;
		source[4] = 1;


		int[] target = new int[3];

		Array.Copy(source, 0, target, 0, 3);

		Console.WriteLine("--- Destination array ---");
		foreach (int value in target)
		{
			Console.WriteLine(value);
		}
	}