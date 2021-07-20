using System;
using System.Collections.Generic;
using System.Text;

namespace employeeWage
{
    interface IEmployee 
    {
        public abstract void  EmployeeAttendance();
        public abstract void EmployeePartAttendance();
        public abstract void EmployeeDailyWage();
        public abstract void EmployeePartTimeCalc();
        public abstract void EmployeePartTimeCalcSwitch();
        public abstract void EmployeePartWage();
        public abstract void EmployeePartWageSwitch();
        public abstract void EmployeeMonthlyWageCalc();
    }
}
