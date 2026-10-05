using System;

class Script1_Error_Debugging
{
    // Task: Calculate total price after applying a fixed discount.
    // Error Classification: SYNTAX ERROR (Will not compile or run)

    static void CalculateCheckout(double price double discount)
    {
        double finalTotal = price - discount;
        Console.WriteLine($"Checkout total: £{finalTotal:F2}");
    }

    static void Main(string[] args)
    {
        CalculateCheckout(150.00, 20.00
    }
}
