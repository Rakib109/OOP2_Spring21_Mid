using System;
public class Program
{
	public static void Main(string[] args)
	{
		int i, j, v = 1;
		int[] arr = new int[5];

		Console.Write("Enter Five numbers:");
		for (i = 0; i < arr.Length; i++)
		{
			arr[i] = Convert.ToInt32(Console.ReadLine());
		}

		Console.Write("duplicate elements:");
		for (i = 0; i < arr.Length; i++)
		{
			for (j = i + 1; j < arr.Length; j++)
			{
				if (arr[i] == arr[j])
				{
					if (v == 1 && arr[j] != '\0')
					{
						Console.Write(arr[i] + " ");
					}
					arr[j] = '\0';
					v++;
				}
			}
			v = 1;
		}
	}
}