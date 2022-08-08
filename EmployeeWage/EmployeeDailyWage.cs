using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    internal class EmployeeDailyWage
    {
        public int EmpDailyWage()
        {
            int EmployeeHrs = 8;
            int EmployeeWagePerHour = 20;
            int DailyWage = 0;

            Random EmpCheck = new Random();
            int Check = EmpCheck.Next(0, 2);
            int EmployeePresent = 1;

            if (Check == EmployeePresent)
            {
                Console.WriteLine("Employee is Present");
                DailyWage = EmployeeHrs * EmployeeWagePerHour;
            }
            else
            {
                Console.WriteLine("employee is absent");
            }
            return DailyWage;
        }
    }
}
