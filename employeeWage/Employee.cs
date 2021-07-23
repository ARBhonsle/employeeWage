using System;
using System.Collections.Generic;
using System.Text;

namespace employeeWage
{
    class Employee : IEmployee
    {
        int attendance;
        readonly int WAGE_PER_HR = 20, FULL_DAY = 8, PART_TIME = 4, WORKING_DAYS=20;
        double salary, monthlyWage = 0;
        public void EmployeeWage()
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
                Console.Write(salary + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Monthly Salary: " + monthlyWage);
        }
    }
}
