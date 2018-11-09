using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Day3_Overriding1
{
    class Employee
    {
        private int EmployeeId;
        private string EmployeeName;
        private int EmployeeSalary;
      
        public Employee(int EmployeeId,string EmployeeName,int EmployeeSalary)
        {
            this.EmployeeId = EmployeeId;
            this.EmployeeName = EmployeeName;
            this.EmployeeSalary = EmployeeSalary;
        }
            public int PEmployeeID
        {
            get
            {
                return this.EmployeeId;
            }
        }
        public string PEmployeeName
        {
            get
            {
                return this.EmployeeName;
            }
        }
        public int PEmployeeSalary
        {
            get
            {
                return this.EmployeeSalary;
            }
        }
        public string GetWork()
        {
            return "dev .net app";
        }
        public virtual int GetSalary(int days)
        {
            int Bonus = 2000;
            int TDS = 1000;
            int Salary = (this.EmployeeSalary / 30 * days) + Bonus - TDS;
            return Salary;
        }

    }
}
