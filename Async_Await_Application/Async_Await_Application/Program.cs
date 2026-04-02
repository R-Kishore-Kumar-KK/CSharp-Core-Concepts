class Program
{
    static async Task Main()
    {
        //Without async and await (Blocking)
        Console.WriteLine("-------Without Async/Await---------");
        Console.WriteLine("Start");
        LongTask();
        Console.WriteLine("End");

        //With async and await (Non-Blocking)
        Console.WriteLine("-------With Async/Await---------");
        Console.WriteLine("Start");
        await LongTaskAsync();
        Console.WriteLine("End");

        //Simple async method
        Console.WriteLine("-------Simple Async Method---------"); 
        Console.WriteLine("Fetching Data");
        String data = await FetchDataAsync();
        Console.WriteLine(data);
        Console.WriteLine("Data Fetching Completed");

        //Parallel Execution
        Console.WriteLine("-------Parallel Execution---------");
        Console.WriteLine("Starting Tasks");
        Task task1 = Task1();
        Task task2 = Task2();
        await Task.WhenAll(task1, task2);
        Console.WriteLine("Both Tasks Completed");

        //Returning Values
        Console.WriteLine("-------Returning Values----------");
        int result = await CalculateSumAsync(5, 10);
        Console.WriteLine("Result: " + result);

        //Real-world Example
        Console.WriteLine("-------Real-world Example--------- ");
        Console.WriteLine("Order Placed");
        await ProcessOrderAsync();
        Console.WriteLine("Order Completed");
    }

    static void LongTask()
    {
        Thread.Sleep(5000);
        Console.WriteLine("Long Task Completed");
    }

    static async Task LongTaskAsync()
    {
        await Task.Delay(5000);
        Console.WriteLine("Long Task Async/await Completed");
    }

    static async Task<string> FetchDataAsync()
    {
        await Task.Delay(2000); // Simulate data fetching delay
        return "Data fetched successfully!";
    }

    static async Task Task1()
    {
        await Task.Delay(3000);
        Console.WriteLine("Task 1 Completed");
    }

    static async Task Task2()
    {
        await Task.Delay(2000);
        Console.WriteLine("Task 2 Completed");
    }

    static async Task<int> CalculateSumAsync(int a, int b)
    {
        await Task.Delay(1000); // Simulate some asynchronous work
        return a + b;
    }

    static async Task ProcessOrderAsync()
    {
        Console.WriteLine("Processing Payment..."); 
        await Task.Delay(2000); // Simulate payment processing delay

        Console.WriteLine("Preparing Order...");
        await Task.Delay(3000); // Simulate order preparation delay

        Console.WriteLine("Shipping Order...");
        await Task.Delay(4000); // Simulate shipping delay
    }
}