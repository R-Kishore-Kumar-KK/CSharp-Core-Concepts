using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement
{
    public interface IEmployee
    {
        int empId { get; set; }
        String empName { get; set; }
        String dept {  get; set; }
        void displayEmployeeDetails();
        decimal calculateSalary();
    }
}
