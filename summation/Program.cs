using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace summation
{
    class Program
    {
        static void Main(string[] args)
        {
            float X = 0.06f;
            float Y = 5.94f;
            float Z =X+Y;

            Console.WriteLine("Summation of 2 numbers =" + (X + Y));

            if (Z == 6)

                Console.WriteLine("Equal");

            else

                Console.WriteLine("Not Equal");
            Console.WriteLine();

            Console.WriteLine("greatest value between X and y");

            if (X > Y)

                Console.WriteLine("X is greater!!");

            else

                Console.WriteLine("Y is greater!!");
            Console.ReadKey();
        }

    }
    }

