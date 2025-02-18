using System;
public class FindArrayAverage
{
    // Method to calculate the average of an array
    public static double CalculateAverage(int[] numbers)
    {
        if(numbers.Length == 0)
            {
                Console.WriteLine("The array is empty, so Average is Zero.");
                return 0; // Return "Zero" to indicate an empty array
            }
        
        int sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
                
            Console.WriteLine("Length of the array is " + numbers.Length);
            sum += numbers[i];
        }
        return sum / numbers.Length;
    }

    /*public static void Main()
    {
        int[] numbers = {}; // Empty array
        double average = FindArrayAverage.CalculateAverage(numbers);
        Console.WriteLine("The average is: " + average);
    }
    */
}