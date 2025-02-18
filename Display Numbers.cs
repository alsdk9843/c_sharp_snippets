

using System.Runtime.CompilerServices;

public class DisplayNumbers()
{
    public static void Display(double number)
    {
        int i;
        for (i = 1; i <= number; i++)
        Console.WriteLine(i);
    }

    /*public static void Main(string[] args)
    {
        double LastNumber = 10;
        Display(LastNumber);
    }
    */
}