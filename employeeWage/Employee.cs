using System;
using System.Collections.Generic;
using System.Text;

namespace employeeWage
{
    class Employee : IEmployee
    {
        readonly int WAGE_PER_HR= 20;
        readonly int FULL_DAY = 8;
        readonly int PART_TIME = 4;
        double salary;
        public void EmployeeWage()
        {
            Random random = new System.Random();
            int attendance = random.Next(0, 3);
            if (attendance == 0)
            {
                Console.WriteLine("Employee Absent");
                salary = 0;
            }
            else if (attendance == 1)
            {
                Console.WriteLine("Employee Present for Part Time");
                salary = WAGE_PER_HR * PART_TIME;
            }
            else
            {
                Console.WriteLine("Employee Present for Full Time");
                salary = WAGE_PER_HR * FULL_DAY;
            }
            Console.WriteLine("Salary: " + salary);
        }       
    }
    
}
