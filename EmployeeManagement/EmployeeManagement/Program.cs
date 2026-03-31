using EmployeeManagement;

int empId;
String empName;
String dept;
decimal monthlySalary;

Console.Write("Enter Employee ID: ");
empId = int.Parse(Console.ReadLine());

Console.Write("Enter Employee Name: ");
empName = Console.ReadLine();

Console.Write("Enter Employee Department: ");
dept = Console.ReadLine();

Console.Write("Enter Employee Salary: ");
monthlySalary = decimal.Parse(Console.ReadLine());

IEmployee employee = new EmployeeDetails(empId, empName, dept, monthlySalary);

employee.displayEmployeeDetails();
Console.WriteLine("Annaul Salary: " + employee.calculateSalary());

EmployeeDetails emp = (EmployeeDetails)employee;
Console.WriteLine($"Monthly Salary: {emp.monthlySalary}");