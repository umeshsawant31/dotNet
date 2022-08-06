// See https://aka.ms/new-console-template for more information

using System;

namespace TypeCasting
    {
        class program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Type Casting");
                int a = 31;
                float d = a;
                Console.WriteLine("int to float "+d);
                Console.WriteLine("Type Casting");
                float c = 31.456f;
                int f = (int)c;
                Console.WriteLine("int to float " + f);
                Console.WriteLine("enter first name ");
                string firstName = Console.ReadLine();
                Console.WriteLine("enter 1st number");
                float b = float.Parse(Console.ReadLine());
                Console.WriteLine("Enter 2nd number");
                float e=float.Parse(Console.ReadLine());
                float v = d + e;
                Console.WriteLine("my first value {0},{1},{2}",e,d,v);
           

            }
        }
    }