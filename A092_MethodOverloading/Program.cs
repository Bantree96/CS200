﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A092_MethodOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Print(19);
            Print(0.123);
            Print("Sum = ", 123.4);

        }

        private static void Print(double x)
        {
            Console.WriteLine(x);
        }

        private static void Print(string s, double x)
        {
            Console.WriteLine(s + x);
        }

        private static void Print(int x)
        {
            Console.WriteLine(x);
        }
    }
}
