namespace EmployeeWage
{
    internal class Program
    {
        static void Main(string[] args)
        {
           EmployeeWage EmpWage = new EmployeeWage();
            EmpWage.EmployeePartTimeFullTime();

            EmployeePresentAbsent EmpPresent = new EmployeePresentAbsent();
            EmpPresent.PresentAbsent();

            EmployeeDailyWage EmpDailywage = new EmployeeDailyWage();
            EmpDailywage.EmpDailyWage();

        }
    }
}