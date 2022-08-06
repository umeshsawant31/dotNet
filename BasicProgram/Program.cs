using System;

namespace ClassObjectMethod
{

    internal class Program
    {
        int number1;
        int number2;
        public void Addition()
        {
            int result = number1 + number2;
            Console.WriteLine("Addition is: " + result);
        }
        public int ReturnMethod()
        {
            int result = number1 + number2;
            return result;
        }
        public void PrintMessage(string firstName, string addr)
        {
            Console.WriteLine("Hello {0},{1}", firstName, addr);
        }
        public float ParameterAndRetun(float numVar1, float numVar2)
        {
            float resValue = numVar1 + numVar2;
            return resValue;
        }
        internal static void StaticMethod()
        {
            Console.WriteLine("Static Method");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Program obj = new Program();
            obj.number1 = 20;
            obj.number2 = 30;
            obj.Addition();
            Console.WriteLine(obj.ReturnMethod());
            obj.PrintMessage("Shweta Sapkal","Satara");
            float s=obj.ParameterAndRetun(23.34f,45.34f);
            Console.WriteLine(s);
            Program.StaticMethod();
            Console.WriteLine("ReturnTypeMethod"+res);

            CalculatorMethod obj1=new CalculatorMethod();
            //obj1.Addition1();
           // CalculatorMethod.MethodStatic();

        }

    }

}