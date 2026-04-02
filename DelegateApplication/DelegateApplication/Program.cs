namespace DelegateApplication
{
    class Program
    {
        //Step1: Declaring a delegate
        public delegate void PrintDelgate(string msg);

        public delegate void Notify();

        
        static void Main()
        {
            //Step2: Assign method to delegate
            PrintDelgate del = showMessage;

            //Step3: Invoke delegate
            del("Hello from delegate");

            Notify notify = method1;
            notify();
            notify = method2;
            notify();


            ActionExample();

            FuncExample();

            PredicateExample();
        }

        static void PredicateExample()
        {
            Predicate<int> isEven = num => num % 2 == 0;
            Console.WriteLine("Is 4 even? " + isEven(4));
            Console.WriteLine("Is 5 even? " + isEven(5));

            //Real-world Example with List
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6 };
            List<int> evenNumbers = numbers.FindAll(isEven);

            Console.WriteLine("Even Numbers:");
            foreach (var num in evenNumbers)
            {
                Console.WriteLine(num);
            }
        }

        static void FuncExample()
        {
            //Func with 2 Parameters and 1 return
            Func<int, int, int> add = (a, b) => a + b;
            int result = add(5, 10);
            Console.WriteLine("Func Result: " + result);

            //Func with String Processing
            Func<string, string> toUpper = s => s.ToUpper();
            Console.WriteLine("Func String Result: " + toUpper("hello func"));
        }

        static void ActionExample()
        {
            //Action with one parameter
            Action<string> printAction = aMsg => Console.WriteLine("Action Message: " + aMsg);
            printAction("Hello KK");

            //Action with multiple Parameters
            Action<int, int> sumAction = (a, b) => Console.WriteLine("Sum: " + (a + b));
            sumAction(10, 20);
        }

        static void showMessage(string message)
        {
            Console.WriteLine(message);
        }

        static void method1()
        {
            Console.WriteLine("Method 1 Called");
        }

        static void method2()
        {
            Console.WriteLine("Method 2 Called");
        }
    }
}