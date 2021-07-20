using System;

namespace employeeWage
{
    class Program : Employee
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program!");
            IEmployee emp = new Employee();
            //emp.EmployeeAttendance();
            //emp.EmployeeDailyWage();

           // emp.EmployeePartAttendance();
           // emp.EmployeePartTimeWage();
            //emp.EmployeePartTimeCalc();
            //emp.EmployeePartWage();

            emp.EmployeePartTimeCalcSwitch();
            emp.EmployeePartWageSwitch();
        }
    }
}
