﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pasantia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("EJERCICIOS #1\n");

            int x;

            for (x = 1; x <= 100; x++)
            {
                if (x % 3 == 0 && x % 5 == 0)
                {
                    Console.WriteLine(x + "FizzBuzz");
                }
                else if (x % 3 == 0)
                {
                    Console.WriteLine(x + "Fizz");
                }
                else if (x % 5 == 0)
                {
                    Console.WriteLine(x + "Buzz");
                }
                else
                {
                    Console.WriteLine(x);
                }
            }
        }
    }
}
