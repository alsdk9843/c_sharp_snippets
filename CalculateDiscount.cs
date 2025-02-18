public class CalculateDiscount
{
    // Method to calculate the final price after a discount
    public static double ApplyDiscount(double price, double discountPercentage)
    {
        return price - ((discountPercentage / 100) * price);
    }

    /*public static void Main()
    {
        double finalPrice = CalculateDiscount.ApplyDiscount(1000, 15);
        Console.WriteLine("The final price after discount is: " + finalPrice);
    }
    */
}