using System;
using System.Collections.Generic;
using System.Text;

namespace employeeWage
{
    class Employee : IEmployee
    {
        int attendance;
        public void  EmployeeAttendance()
        {
            Random random = new System.Random();
             attendance=random.Next(0, 2);
            if (attendance == 0)
            {
                Console.WriteLine("Employee Absent");
            }
            else
            {
                Console.WriteLine("Employee Present");
            }
        }
    }
}
