public class AsyncSolutnWithLambdaOp
{ 
    public static async Task PerformLongOperationAsync()
    {
        try
        {
            Console.WriteLine("Operation started...");
            await Task.Delay(3000); // Simulate a delay
            Console.WriteLine("After await..."); // Simulate a breakpoint
            throw new InvalidOperationException("Simulated long operation error.");
            Console.WriteLine("Operation completed.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }
    

    public static void Main(string[] args)
    {
    // Calling the asynchronous method
    Task.Run(async () => await PerformLongOperationAsync()).Wait();
    Console.WriteLine("Main method completed.");
    }
}


