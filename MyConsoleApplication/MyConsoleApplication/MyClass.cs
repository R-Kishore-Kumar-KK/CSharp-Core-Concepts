using System;
using System.Collections.Generic;
using System.Text;

namespace MyConsoleApplication
{
    public class MyClass
    {
        int empId;
        String name;

        public MyClass()
        {
            
        }

        public MyClass(int empId, String name) { 
            this.empId = empId;
            this.name = name;
        }

        public static void method1()
        {

        }

        public static void method2(int a)
        {
            Console.WriteLine("The Number: " + a);
        }

        public static int method3()
        {
            int v = 0;
            return v;
        }

        public static int method4(int m, int n) {
            int sum = m + n;
            return sum;
        }

        public int method5() {
            return 0;
        }

        private String name1;
        private int age;

        public String Name1
        {
            get {return name1;}
            set {name1 = value;}
        }

        public int Age
        {
            get{return age;}
            set 
            { 
                if(value >= 18)
                {
                    age = value;
                }
                else
                {
                    Console.WriteLine("Age cannot be less than 18.");
                }
            }
        }

        public void dispalyInfo()
        {
            Console.WriteLine("Name: " + name1 + " Age: " + age);
        }

        public int stuId { get; set; }
        public int age1 { get; set; }

        public MyClass(int stuId, int age)
        {
            this.stuId = stuId;
            this.age1 = age;
        }

        public void displayStuInfo()
        {
            Console.WriteLine("Student Id: " + stuId  + " Student Age: " + age1);
        }
    }
}
