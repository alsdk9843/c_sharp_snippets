using Pastel;

public class Async_and_Await_basics
{
    public async Task DownloadDataAsync()
    {
        try
        {
            Console.WriteLine("Download started...");
            //await task1 = Task.Delay(3000);
            Task task_dnld1 = Task.Delay(3000);
            Console.WriteLine("Downlaod in progress");
            //await task2 = Task.Delay(2000);
            Task task_dnld2 = Task.Delay(2000);
            Console.WriteLine("Download completed");
            await Task.WhenAll (task_dnld1, task_dnld2);
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred:" + ex.Message);
        }

    }

    public async Task DownloadDataAsync2()
    {
        Console.WriteLine("Download 2 started...");
        //await task1 = Task.Delay(3000);
        Task task_dnld1 = Task.Delay(3000);
        Console.WriteLine("Downlaod 2 in progress");
        //await task2 = Task.Delay(2000);
        Task task_dnld2 = Task.Delay(2000);
        Console.WriteLine("Download 2 completed");
        await Task.WhenAll (task_dnld1, task_dnld2);
        
    }

    public static async Task Main(string[] args)
    {
        /*Async_and_Await()
        {
            
        }*/
        Async_and_Await_basics ClassInstance = new Async_and_Await_basics();

        await ClassInstance.DownloadDataAsync();
        Console.WriteLine("Partial Download completed");
        await ClassInstance.DownloadDataAsync();

        Console.WriteLine("Download 1 completed");

        Task task1 = ClassInstance.DownloadDataAsync2();
        Console.WriteLine("Partial Download 2 completed");
        Task task2 =  ClassInstance.DownloadDataAsync2();

        Console.WriteLine("Download 2 completed");

        Console.WriteLine("All Downloads completed");
        //task2 = await DownloadDataAsync();
        await Task.WhenAll (task1, task2);

    }

}