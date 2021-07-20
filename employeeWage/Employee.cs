using System;
using System.Collections.Generic;
using System.Text;

namespace employeeWage
{
    class Employee : IEmployee
    {
        bool isPresent=false;
        bool isPartTime = false;
        int WAGE_PER_HR= 20;
        int FULL_DAY = 8;
        int PART_TIME = 4;
        double salary;

        public void  EmployeeAttendance()
        {
            Random random = new System.Random();
            int attendance = random.Next(0, 2);
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
        public void EmployeePartAttendance()
        {
            Random random = new System.Random();
            int attendance = random.Next(0, 3);
            if (attendance == 0)
            {
                Console.WriteLine("Employee Absent");
                isPresent = false; isPartTime = false;
            }
            else if (attendance == 1)
            {
                Console.WriteLine("Employee Present for Part Time");
                isPartTime = true;
            }
            else
            {
                Console.WriteLine("Employee Present for Full Time");
                isPresent = true;
            }
        }
        public void EmployeeDailyWage()
        {
            if (isPresent)
            {
                salary = WAGE_PER_HR * PART_TIME;
            }
            else
            {
                salary = 0;
            }
            Console.WriteLine("Salary: " + salary);
        }
        public void EmployeePartTimeWage()
        {
            if (isPresent && !isPartTime)
            {
                salary = WAGE_PER_HR * FULL_DAY;
            }
            else if (isPartTime && !isPresent)
            {
                salary = WAGE_PER_HR * PART_TIME;
            }
            else
            {
                salary = 0;
            }
            Console.WriteLine("Salary: " + salary);
        }
        
    }
    
}
