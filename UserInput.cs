

public class UserInput
{
    public static void HelloUser()
    {
        Console.WriteLine("Write your name.");
        string UserName = Console.ReadLine();
        Console.WriteLine("Hello, " + UserName);
    }

    /*public static void Main ()
    {
        HelloUser();
    }
    */
}