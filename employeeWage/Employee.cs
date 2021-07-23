using System;
using System.Collections.Generic;
using System.Text;

namespace employeeWage
{
    class Employee : IEmployee
    {
        int attendance;
        readonly int WAGE_PER_HR= 20, FULL_DAY = 8, PART_TIME = 4;
        double salary;
        public void EmployeeWage()
        {
            Random random = new System.Random();
            attendance = random.Next(0, 3);
            switch (attendance)
            {
                case 0:
                    Console.WriteLine("Employee Absent");
                    salary = 0;
                    break;
                case 1:
                    Console.WriteLine("Employee Present for Part Time");
                    salary = WAGE_PER_HR * PART_TIME;
                    break;
                case 2:
                    Console.WriteLine("Employee Present for Full Time");
                    salary = WAGE_PER_HR * FULL_DAY;
                    break;
            }
            Console.WriteLine("Salary: " + salary);
        }               
    }
}
