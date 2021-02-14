using System;

using System.Collections.Generic;

using System.Text;



namespace CSApp

{

    class Program

    {

        static int[] BubbleSort(int[] numarray)

        {

            int max = numarray.Length;

            for (int i = 1; i < max; i++)

            {

                for (int j = 0; j < max - i; j++)

                {



                    if (numarray[j] > numarray[j + 1])

                    {

                        int temp = numarray[j];

                        numarray[j] = numarray[j + 1];

                        numarray[j + 1] = temp;

                    }

                }

            }

            return numarray;

        }



        static int[] Find_Unique_Elements(int[] numarray)

        {

            BubbleSort(numarray);

            int element = numarray[0];

            int count = 1;

            for (int i = 1; i < numarray.Length; i++)

            {

                if (element == numarray[i])

                    continue;

                else

                {

                    element = numarray[i];

                    count++;

                }

            }



            int[] result = new int[count];



            count = 0;

            element = numarray[0];

            result[count++] = element;

            for (int i = 1; i < numarray.Length; i++)

            {

                if (element == numarray[i])

                    continue;

                else

                {

                    element = numarray[i];

                    result[count++] = element;

                }

            }

            return result;

        }



        static void Main(string[] args)

        {

            int[] array1 = new int[] { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100,

                 95, 85, 75, 65, 55, 45, 35, 25, 15, 05,

                 10, 15, 20, 25, 30, 35, 40, 45, 50, 55

            };



            int[] array2 = new int[] { 15, 25, 35, 45, 55,

                 12, 22, 32, 43, 52,

                 15, 25, 35, 45, 55

            };



            int[] p1 = Find_Unique_Elements(array1);

            int[] p2 = Find_Unique_Elements(array2);



            Console.Write("\n\nUnique Sorted Elements in Array1: ");

            for (int i = 0; i < p1.Length; i++)

                Console.Write(p1[i] + " ");

            Console.Write("\n\nUnique Sorted Elements in Array2: ");

            for (int i = 0; i < p2.Length; i++)

                Console.Write(p2[i] + " ");

            Console.WriteLine();

        }

    }

}
