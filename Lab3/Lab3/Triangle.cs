using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Triangle
    {
        private int x,y,z;
        public int X
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
            }
        }
        public int Y
        {
            get
            {
                return y;
            }
            set
            {
                y = value;
            }
        }
        public int Z
        {
            get
            {
                return z;
            }
            set
            {
                z = value;
            }
        }
        public void ShowInfo()
        {

            Console.WriteLine("First Side: " + x);
            Console.WriteLine("Second Side: " + y);
            Console.WriteLine("Third Side: " + z);

        }
        public void TestTriangle()
        {
            if (x == y && y == z)
            {
                Console.WriteLine("Equilateral");
            }
            else if(x==y || y==z || z == x)
            {
                Console.WriteLine("Isosceles");
            }
            else
            {
                Console.WriteLine("Scalene");
            }
        }
    }
}
