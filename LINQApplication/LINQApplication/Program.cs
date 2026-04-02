using LINQApplication;
using System;
public class Program
{
    static void Main(string[] args)
    {
        //Sample Data
        List<Employee> employees = new List<Employee>()
        {
            new Employee(){ID=1,name="John",salary=50000,deptID=1},
            new Employee(){ID=2,name="Jane",salary=60000,deptID=2},
            new Employee(){ID=3,name="Doe",salary=55000,deptID=1},
            new Employee(){ID=4,name="Smith",salary=70000,deptID=3}
        };

        List<Department> departments = new List<Department>()
        {
            new Department(){deptID=1,deptName="HR"},
            new Department(){deptID=2,deptName="IT"},
            new Department(){deptID=3,deptName="Finance"}
        };

        Console.WriteLine("-------WHERE (Filter Salary > 40000)-----------");
        var highSalaryEmployees = employees.Where(e => e.salary > 40000);
        PrintEmployees(highSalaryEmployees);

        Console.WriteLine("----------SELECT (Only Names)---------------");
        var names = employees.Select(e => e.name);
        foreach (var employee in names)
        {
            Console.WriteLine(employee);
        }

        Console.WriteLine("----------FIRST & FIRST OR DEFAULT--------------");
        var first = employees.First(e => e.salary > 30000);
        Console.WriteLine("FIRST: " + first.name);
        var safe = employees.FirstOrDefault(e => e.salary > 100000);
        Console.WriteLine("FIRST OR DEFAULT: " + (safe == null ? "NULL" : safe.name));

        Console.WriteLine("----------COUNT / ANY / ALL------------");
        Console.WriteLine("Count > 30000: " + employees.Count(e => e.salary > 30000));
        Console.WriteLine("Any > 60000: " + employees.Any(e => e.salary > 60000));
        Console.WriteLine("All > 20000: " + employees.All(e => e.salary > 20000));

        Console.WriteLine("------------GROUP BY Department------------");
        var groups = employees.GroupBy(e => e.deptID);
        foreach (var group in groups) 
        { 
            Console.WriteLine("DeptID: " + group.Key);
            foreach (var emp in group)
            {
                Console.WriteLine($"  {emp.name} - {emp.salary}");
            }
        }

        Console.WriteLine("----------JOIN Employees with Departments ------------");
        var joinResults = from emp in employees
                          join dept in departments
                          on emp.deptID equals dept.deptID
                          select new 
                          { 
                            emp.name,
                            dept.deptName
                          };
        foreach (var emp in joinResults) 
        { 
            Console.WriteLine($"Employee: {emp.name}, Department: {emp.deptName}");
        }
    }

    static void PrintEmployees(IEnumerable<Employee> employees)
    {
        foreach (var emp in employees)
        {
            Console.WriteLine($"ID: {emp.ID}, Name: {emp.name}, Salary: {emp.salary}, DeptID: {emp.deptID}");
        }
    }
}