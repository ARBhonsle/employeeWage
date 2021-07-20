using System;
using System.Collections.Generic;
using System.Text;

namespace employeeWage
{
    class Employee : IEmployee
    {
        int attendance;
        int WAGE_PER_HR= 20;
        int FULL_DAY = 8;
        int PART_TIME = 4;
        int WORKING_DAYS = 20;
        double salary=0;
        double monthlyWage = 0;

        public void  EmployeeAttendance()
        {
            Random random = new System.Random();
            attendance = random.Next(0, 2);
            if (attendance == 0)
            {
                Console.WriteLine("Employee Absent");
            }
            else
            {
                Console.WriteLine("Employee Present");
            }
        }
        public void EmployeePartAttendance()
        {
            Random random = new System.Random();
            attendance = random.Next(0, 3);
            if (attendance == 0)
            {
                Console.WriteLine("Employee Absent");
            }
            else if (attendance == 1)
            {
                Console.WriteLine("Employee Present for Part Time");
            }
            else
            {
                Console.WriteLine("Employee Present for Full Time");
            }
        }
        public void EmployeeDailyWage()
        {
            if (attendance != 0 )
            {
                salary = WAGE_PER_HR * FULL_DAY;
            }
            else
            {
                salary = 0;
            }
            Console.WriteLine("Salary: " + salary);
        }
        public void EmployeePartTimeCalc()
        {
            Random random = new System.Random();
            attendance = random.Next(0, 3);
            if (attendance == 0)
            {
                Console.WriteLine("Employee Absent");
            }
            else if (attendance == 1)
            {
                Console.WriteLine("Employee Present for Part Time");
            }
            else
            {
                Console.WriteLine("Employee Present for Full Time");
            }
        }
        public void EmployeePartTimeCalcSwitch()
        {
            Random random = new System.Random();
            attendance = random.Next(0, 3);
            switch (attendance)
            {
                case 0:
                    Console.WriteLine("Employee Absent");
                    break;
                case 1:
                    Console.WriteLine("Employee Present for Part Time");
                    break;
                case 2:
                    Console.WriteLine("Employee Present for Full Time");
                    break;
            }
        }
        public void EmployeePartWage()
        {
            if (attendance == 2)
            {
                salary = WAGE_PER_HR * FULL_DAY;
            }
            else if (attendance == 1)
            {
                salary = WAGE_PER_HR * PART_TIME;
            }
            else
            {
                salary = 0;
            }
            Console.WriteLine("Salary: " + salary);
        }
        public void EmployeePartWageSwitch()
        {
            switch (attendance)
            {
                case 0: salary = 0;
                    break;
                case 1: salary = WAGE_PER_HR * PART_TIME;
                    break;
                case 2: salary = WAGE_PER_HR * FULL_DAY; ;
                    break;
            }
            Console.WriteLine("Salary: " + salary);
        }
        public void EmployeeMonthlyWageCalc()
        {
            for(int i = 0; i < WORKING_DAYS; i++)
            {
                Random random = new System.Random();
                attendance = random.Next(0, 3);                
                switch (attendance)
                {
                    case 0:
                        salary = 0;
                        break;
                    case 1:
                        salary = WAGE_PER_HR * PART_TIME;
                        break;
                    case 2:
                        salary = WAGE_PER_HR * FULL_DAY; ;
                        break;
                }
                monthlyWage += salary;
                Console.WriteLine(salary + " ");
            }
            Console.WriteLine("Monthly Salary: " + monthlyWage);
        }
    }
    
}
