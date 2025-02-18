// See https://aka.ms/new-console-template for more information
//using System.Drawing;
//using Pastel;

//Console.WriteLine("Hello, .NET World!".Pastel(Color.LightGreen));

//Original example project to print on Console


// Method to divide two numbers

using System;
public class Divide
{
    public static double DivideNumbers(double numerator, double denominator)
        {
            if (denominator == 0)
            {
                Console.WriteLine("User has entered 'denominator = 0'. Denominator should be a non-zero number. ");
                return double.NaN; // Return "Not a Number" to indicate an error
            }
            
            else 
            {
                double result = numerator / denominator;
                return result;
            }
            
        }

    /*public static void Main()
        {
            // Attempt to divide 10 by 0
            double quotient = Divide.DivideNumbers(10, 0);
            Console.WriteLine("The result is: " + quotient);
        }
    */
}
