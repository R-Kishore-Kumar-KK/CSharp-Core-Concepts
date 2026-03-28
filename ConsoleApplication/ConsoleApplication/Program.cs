using System.Diagnostics;
using System.Transactions;

namespace ConsoleApplication
{
    class program
    {
        static void Main(string[] args)
        {
            String name;

            char section;

            int number;

            double percentage;

            name = "Kishore";

            section = 'A';

            number = 27;

            percentage = 90.5;

            Console.WriteLine("Name: " + name);
            Console.WriteLine("Section: " + section);
            Console.WriteLine("Number: " + number);
            Console.WriteLine("Percentage: " + percentage);

            Console.ReadLine();

            string firstName;
            Console.Write("Enter Your Name:");
            firstName = Console.ReadLine();

            char sec;
            Console.Write("Enter Your Section:");
            sec = Convert.ToChar(Console.ReadLine());

            double per;
            Console.Write("Enter Your Percentage:");
            per = Convert.ToDouble(Console.ReadLine());

            int num;
            Console.Write("Enter Your Mark:");
            num = Convert.ToInt32(Console.ReadLine());
            //num = int.Parse(Console.ReadLine());

            int mark1, mark2, sum;

            Console.WriteLine("Enter Your Mark 1:");
            mark1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Your Mark 2:");
            mark2 = int.Parse(Console.ReadLine());

            sum = mark1 + mark2;
            Console.WriteLine("Sum: " + sum);
            Console.ReadLine();

            int diff;
            diff = mark1 - mark2;
            Console.WriteLine("Differenece: " + diff);
            Console.ReadLine();

            int multi;
            multi = mark1 * mark2;
            Console.WriteLine("Multiply: " + multi);
            Console.ReadLine();

            int quotient;
            quotient = mark1 / mark2;
            Console.WriteLine("Quotient: " + quotient);
            Console.ReadLine();

            int reminder;
            reminder = mark1 % mark2;
            Console.WriteLine("Reminder: " + reminder);
            Console.ReadLine();

            Console.WriteLine("Mark1 == Mark2:" + (mark1 == mark2));
            Console.ReadLine();
            Console.WriteLine("Mark1 != Mark2:" + (mark1 != mark2));
            Console.ReadLine();
            Console.WriteLine("Mark1 < Mark2:" + (mark1 < mark2));
            Console.ReadLine();
            Console.WriteLine("Mark1 <= Mark2:" + (mark1 <= mark2));
            Console.ReadLine();
            Console.WriteLine("Mark1 > Mark2:" + (mark1 > mark2));
            Console.ReadLine();
            Console.WriteLine("Mark1 >= Mark2:" + (mark1 >= mark2));
            Console.ReadLine();

            Console.Write("Enter Your age: ");
            int age = int.Parse(Console.ReadLine());
            

            if(age >= 18)
            {
                Console.WriteLine("Eligible to Vote");
            }
            else
            {
                Console.WriteLine("Not Eligible to Vote.");
            }

            if (sum >= 90)
            {
                Console.WriteLine("Grade A");
            }
            else if (sum >= 75 && sum < 90)
            {
                Console.WriteLine("Grade B");
            }
            else if (sum >= 50 && sum < 75)
            {
                Console.WriteLine("Grade C");
            }
            else
            {
                Console.WriteLine("Grade D");
            }

            int month;

            Console.Write("Enter Month Number: ");
            month = int.Parse(Console.ReadLine());
            
            switch (month) {
                case 1:
                    Console.WriteLine("January");
                    break;
                case 2:
                    Console.WriteLine("February");
                    break;
                case 3:
                    Console.WriteLine("March");
                    break;
                case 4:
                    Console.WriteLine("April");
                    break;
                case 5:
                    Console.WriteLine("May");
                    break;
                case 6:
                    Console.WriteLine("June");
                    break;
                case 7:
                    Console.WriteLine("July");
                    break;
                case 8:
                    Console.WriteLine("August");
                    break;
                case 9:
                    Console.WriteLine("September");
                    break;
                case 10:
                    Console.WriteLine("October");
                    break;
                case 11:
                    Console.WriteLine("November");
                    break;
                case 12:
                    Console.WriteLine("December");
                    break;
                default:
                    Console.WriteLine("Invalid Number");
                    break;
            }

            int input;
            Console.WriteLine("Enter a Number: ");
            input = int.Parse(Console.ReadLine());

            while (input <= 3)
            {
                Console.WriteLine("Number: " + input);
                input++;
            }
            Console.ReadLine();

            int rows;
            Console.Write("Enter a Row Number: ");
            rows = int.Parse(Console.ReadLine());

            int i = 1;
            while (i <= rows) {
                int j = 1;
                while (j <= i) { 
                    Console.Write("*");
                    j++;
                }
                Console.WriteLine(" ");
                i++;
            }

            int k = 0;
            k = 10;

            do
            {
                Console.WriteLine("Value of 'i' is " + k);
                k = k + 10;
            } while (k < 100);

            int mul;
            Console.Write("Enter the number for multiply: ");
            mul = int.Parse(Console.ReadLine());

            for (int a = 1; a <= 10; a++) {
                Console.WriteLine(mul + " * " + a + " = " + (mul * a));
            }

            for (int b = 1; b <= 10; b++) { 
                if(b < 6)
                {
                    continue;
                }

                Console.WriteLine(b);
            }
        }
    }
}