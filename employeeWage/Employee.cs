using System;
using System.Collections.Generic;
using System.Text;

namespace employeeWage
{
    class Employee : IEmployee
    {
        bool isPresent;
        int WAGE_PER_HR= 20;
        int FULL_DAY = 8;
        double salary;

        public void  EmployeeAttendance()
        {
            Random random = new System.Random();
            int attendance=random.Next(0, 2);
            if (attendance == 0)
            {
                Console.WriteLine("Employee Absent");
                isPresent = false;
            }
            else
            {
                Console.WriteLine("Employee Present");
                isPresent = true;
            }
        }
        public void EmployeeDailyWage()
        {
            if(!isPresent)
            {
                salary = 0;
            }
            else
            {
                salary = WAGE_PER_HR * FULL_DAY;
            }
            Console.WriteLine("Salary: "+salary);
        }
    }
}
