using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    internal class SwitchStatement
    {
        public int EmployeeWagePerHour = 20;
        public int DailyWage =0;
        public int EmpHrs = 0;
        public const int EmployeeFullTime = 1;
        public const int EmployeePartTime = 2;
        public int FullTimeWorkingHrs = 8;
        public int PartTimeWorkingHrs = 4;
        public int WorkingDayPerMonth = 20;

        private int IsemployeePresentAbsent()
        {
            return new Random().Next() % 3;
        }

        public void TotalDailywage()
        {
            int Daynumber = 1;

            while(Daynumber <= WorkingDayPerMonth)
            {
                switch (IsemployeePresentAbsent())
                {
                    case EmployeeFullTime:
                        DailyWage = FullTimeWorkingHrs * EmployeeWagePerHour;
                        break;
                    case EmployeePartTime:
                        DailyWage = PartTimeWorkingHrs * EmployeeWagePerHour;
                        break ;
                    

                }
               // MonthlyWage =+ DailyWage;
            }
            

        }

    }
}
