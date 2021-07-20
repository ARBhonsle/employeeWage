using System;
using System.Collections.Generic;
using System.Text;

namespace employeeWage
{
    interface IEmployee 
    {
        public abstract void  EmployeeAttendance();
        public abstract void EmployeeDailyWage();
        public abstract void EmployeePartTimeCalc();
    }
}
