using System;

class DiscountCalculation
{
    static void Main(string[] args)
    {
        // Input test variable (Change this to test different paths)
        double orderTotal = 125.50;
        int discountPercentage;

        // Specific-to-general boundary logic
        if (orderTotal >= 100.0)
        {
            discountPercentage = 20;
        }
        else if (orderTotal >= 50.0)
        {
            discountPercentage = 10;
        }
        else if (orderTotal >= 0.0)
        {
            discountPercentage = 0;
        }
        else
        {
            discountPercentage = 0;
            Console.WriteLine("Warning: Invalid order total (negative value).");
        }

        Console.WriteLine($"Applied Discount: {discountPercentage}%");
    }
}
