using System;

namespace PassingValueAndRefereance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int value = 5;
            Program.PassByValue(value);
            Console.WriteLine(value);

            Program.PassByRef(ref value);
            Console.WriteLine("After reference operation: "+value);
        }

        static void PassByValue(int a)
        {
            a = a + 10;
            Console.WriteLine("Method output: " + a);
        }

        static void PassByRef(ref int b)
        {
            b = b + 14;
            Console.WriteLine("Reference output: " + b);
        }
    }
}
