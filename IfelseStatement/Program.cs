using System;

namespace Statements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter ur Username");
            //var username = Console.ReadLine();

            //Console.WriteLine("Enter ur Password");
            //var password = Console.ReadLine();

            //if (username=="umesh" &&  password=="1234")
            //{
            //    Console.WriteLine("Login successfully!");
            //}
            //else
            //{
            //    Console.WriteLine("wrong username or password");
            //}



            // uc1 employee wage program ----------------
            //Random rand = new Random();           // create object for random function
            //int empCheck = rand.Next(0, 2);         // randomly generate 0 and 1 number for empCheck
            //Console.WriteLine(empCheck);
            //if (empCheck == 1)
            //{
            //    Console.WriteLine("Employee is present");
            //}
            //else
            //{
            //    Console.WriteLine("Employee is absent");

            //}
            // end of uc 1 --------------------------

            //Console.WriteLine("Enter ur percentage");
            //double percentage = int.Parse(Console.ReadLine());

            //if (percentage >= 80)
            //{
            //    Console.WriteLine("Grade: A1");

            //}
            //else
            //{
            //    Console.WriteLine("Grade: B");
            //}


            //print weekday using if elseif  program----------------
            //Random rand = new Random();           // create object for random function
            //int empCheck = rand.Next(1, 8);         // randomly generate 0 and 1 number for empCheck
            //Console.WriteLine(empCheck);
            //if (empCheck == 1)
            //{
            //    Console.WriteLine("Monday");
            //}
            //else if(empCheck == 2)
            //{
            //    Console.WriteLine("Tuesday");

            //}
            //else if (empCheck == 3)
            //{
            //    Console.WriteLine("Wednesday");

            //}
            //else if (empCheck == 4)
            //{
            //    Console.WriteLine("Thursday");

            //}
            //else if (empCheck == 5)
            //{
            //    Console.WriteLine("Friday");

            //}
            //else if (empCheck == 6)
            //{
            //    Console.WriteLine("Saturday");

            //}
            //else 
            //{
            //    Console.WriteLine("Sunday");

            //}
            //end of --------------------------


            // print weekdays using switch case
            Random rand2 = new Random();
            int empCheck1 = rand2.Next(1, 8);         // randomly generate 0 and 1 number for empCheck
            Console.WriteLine(empCheck1);

            switch(empCheck1)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;

                default: Console.WriteLine("Invalid");
                    break;
            }

            // end of above program ============================




        }


    }
}
