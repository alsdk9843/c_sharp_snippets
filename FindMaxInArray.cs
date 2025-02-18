public class FindMaxInArray
{
    public static int FindMax(int[] numbers)
    {
        int max = int.MinValue;                     // Coursera solution line
        //int max = numbers[numbers.Length - 1];    // Varun's line
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] > max)
            {
                max = numbers[i];
            }
        }
        return max;
    }

    /*
    public static void Main()
    {
        int[] myNumbers = { -5, -10, -3, -8, -2, -12 };
        int maxNumber = FindMaxInArray.FindMax(myNumbers);
        Console.WriteLine("The maximum number is: " + maxNumber);
    }
    */
}