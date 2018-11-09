using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Day3_Overriding1
{
    class Employee_Contract:Employee
    {
        public Employee_Contract(int EmployeeId,string EmployeeName,int EmployeeSalary):base(EmployeeId,EmployeeName,EmployeeSalary)
        {

        }

        public override int GetSalary(int Days)
        {
            int totalsalary = this.PEmployeeSalary / 30 * Days;
            return totalsalary;
        }
    }
}
