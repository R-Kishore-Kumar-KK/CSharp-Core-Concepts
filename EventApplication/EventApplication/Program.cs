using System.Diagnostics;

public class Program 
{ 
    static void OnProcessCompleted() 
    { 
        Console.WriteLine("Process Completed!");
    }

    static void SendEmail()
    {
        Console.WriteLine("Email sent to Customer");
    }

    static void SendSMS()
    {
        Console.WriteLine("SMS sent to Customer");
    }

    static void Main() 
    {
        Process process = new Process();

        //Subscribe
        process.ProcessCompleted += OnProcessCompleted;

        process.StartProcess();

        Order order = new Order();
        order.OrderPlaced += SendEmail;
        order.OrderPlaced += SendSMS;

        order.PlaceOrder();
    }
}

class Process
{
    public delegate void ProcessCompletedHandler();

    //Event declaration
    public event ProcessCompletedHandler ProcessCompleted;

    public void StartProcess()
    {
        Console.WriteLine("Process Started");

        //Raise Event
        ProcessCompleted?.Invoke();
    }
}

class Order
{
    public event Action OrderPlaced;

    public void PlaceOrder()
    {
        Console.WriteLine("Order Placed Successfully");
        OrderPlaced?.Invoke();
    }
}