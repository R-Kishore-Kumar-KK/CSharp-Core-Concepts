using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement 
{
    public class EmployeeDetails : IEmployee
    {
        public int empId { get; set; }
        public String empName { get; set; }
        public String dept { get; set; }

        public decimal monthlySalary {  get; set; }

        public EmployeeDetails(int empId, String empName, String dept, decimal monthlySalary) { 
            this.empId = empId;
            this.empName = empName;
            this.dept = dept;
            this.monthlySalary = monthlySalary;
        }
        public void displayEmployeeDetails()
        {
            Console.WriteLine($"EmpID: {empId}, EmpName: {empName}, Dept: {dept}");
        }
        public decimal calculateSalary()
        {
            return monthlySalary * 12;
        }
    }
}
