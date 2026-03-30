namespace ExceptionHandlingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string> {"Apple", "Banana", "Cherry" };

            try
            {
                String fruit;
                fruit = list[5];
                Console.WriteLine("fruit: " + fruit);
            }
            catch (ArgumentOutOfRangeException ex) {
                Console.WriteLine(ex.Message);
            }

            try
            {
                int number;
                Console.WriteLine("Enter a Number: ");
                number = int.Parse(Console.ReadLine());
            }
            catch (FormatException ex) {
                Console.WriteLine(ex.Message);
            }
        }
    }
}