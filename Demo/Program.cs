﻿
using Demo.OperatorsOverloading;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Operator Overloading - Binary Operators
            Complex c1 = new Complex() { Real = 10, Imag = 6 };
            Console.WriteLine(c1);

            Complex c2 = new Complex() { Real = 5, Imag = 3 };
            Console.WriteLine(c2);

            Complex c3 = default; // Null 

            //c3 = c1 + c2; 

            //Console.WriteLine(c3);

            //c3 = c1 - c2;

            //c3 += c1;
            //c3 -= c2;

            //c3 = ++c1; //prefix
            //c3 = c1++; //postfix

            //c3 = --c1; //prefix
            //c3 = c1--; //postfix
            Console.WriteLine(c3);

            #endregion
        }
    }
}
