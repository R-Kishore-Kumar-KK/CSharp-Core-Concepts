using MyConsoleApplication;

MyClass myClass = new MyClass(10, "Kishore");

MyClass.method1();

int a;
Console.WriteLine("Enter the Number: ");
a = int.Parse(Console.ReadLine());
MyClass.method2(a);

int v = MyClass.method3();
Console.WriteLine("Default: " +  v);

int m, n;
Console.Write("Enter a Number: ");
m = int.Parse(Console.ReadLine());

Console.Write("Enter a Number: ");
n = int.Parse(Console.ReadLine());


int sum = MyClass.method4(m, n);

Console.WriteLine("Sum: "+ sum);

MyClass myClass5 = new MyClass();
int default5 = myClass.method5();

Console.WriteLine("Default 5 : " + default5);

MyClass myClass6 = new MyClass();
myClass6.Name1 = "Test";
myClass6.Age = 28;

Console.WriteLine("Info: ");
myClass6.dispalyInfo();

int stuId;
int stuAge;

Console.WriteLine("Enter Student Id: ");
stuId = int.Parse(Console.ReadLine());

Console.WriteLine("Enter Student Age: ");
stuAge = int.Parse(Console.ReadLine());

MyClass myClass7  = new MyClass(stuId, stuAge);
Console.WriteLine("Student Details:");
myClass7.displayStuInfo();

myClass7.stuId = 102;
myClass7.age1 = 30;

Console.WriteLine("Updated Student Details:");
myClass7.displayStuInfo();