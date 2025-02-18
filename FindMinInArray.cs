public class FindMinInArray
{
    public static int FindMin(int[] numbers)
    {
        //int min = int.MaxValue;                         // Adapting with Coursera's solution for 'Find max'
        int min = numbers[numbers.Length - 1];          // Varun's line
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] < min)
            {
                min = numbers[i];
            }
        }
        return min;
    }

    /*
    public static void Main()
    {
        int[] myNumbers = { -5, -10, -3, -8, -2 };
        int maxNumber = FindMinInArray.FindMin(myNumbers);
        Console.WriteLine("The maximum number is: " + maxNumber);
    }
    */
}