/*
using System.Globalization;

public class MyProgram2FindMaxInArray
{
    int temp;
    int *Number1, *Number2 
    bool swapped =  false;
    public static void Swap(*Number1, *Number2)
    {
        int temp = *Number2;
        *Number2 = *Number1;
        *Number1 = temp;


    }
    public static int FindMax(int[] numbers)
    {
        int temp; 
        bool swapped;
        for (int i = 0; i < numbers.Length; i++)
        {
            swapped = false;
            for (int j = 0; j < numbers.Length-1; j++)
            {
                
                if (numbers[j+1] > numbers[j])  // Using 'Bubble sort to convert array in ascending order
                {
                    temp = numbers[j+1];
                    numbers[ji+1] = numbers[j];
                    numbers[j] = temp;
                }
            }
            
            
        }
        return numbers[0];
    }

    public static void Main()
    {
        int[] myNumbers = { -5, -10, -3, -8, -2 };
        int maxNumber = Program2FindMaxInArray.FindMax(myNumbers);
        Console.WriteLine("The maximum number in the given array is: " + maxNumber);
    }
}

*/