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
        public void  EmployeeWage()
        {
            Random random = new System.Random();
            int attendance=random.Next(0, 2);
            if (attendance == 0)
            {
                Console.WriteLine("Employee Absent");
                salary = 0;
            }
            else
            {
                Console.WriteLine("Employee Present");
                salary = WAGE_PER_HR * FULL_DAY;
            }
            Console.WriteLine("Salary: " + salary);
        }
    }
}
