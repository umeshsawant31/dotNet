using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    internal class EmployeeWage
    {
        public int EmployeePartTimeFullTime()
        {
            int EmployeeWagePerHour = 20;
            int DailyWage = 0;
            int EmpHrs = 0;

            // classname  objectname = new classname(); 
            Random EmpCheck = new Random();
            int Check = EmpCheck.Next(0, 3);
            int EmployeeFullTime = 1;
            int EmployeePartTime = 2;


            if (Check == EmployeeFullTime)
            {
                Console.WriteLine("Employee is Present fulltime");
                EmpHrs = 8;
            }
            else if (Check == EmployeePartTime)
            {
                Console.WriteLine("employee is present Part time");
                EmpHrs = 4;
            }
            else
            {
                Console.WriteLine("employee is absent");
                EmpHrs = 0;
            }

            DailyWage = EmployeeWagePerHour * EmpHrs;
            return DailyWage;
        }
    }
}
