using System;

class CSharpDemo1
{
    static void Main(string[] args)
    {
        // 1. Variables and Data Types
        string itemName = "Cappuccino";
        double itemPrice = 4.50;

        // 2. Interactive Input
        Console.Write($"How many {itemName}s would you like? ");
        string quantityStr = Console.ReadLine();

        // 3. Type Conversion
        int quantity = int.Parse(quantityStr);

        // 4. Correct Syntax & Formatting
        double totalCost = itemPrice * quantity;
        Console.WriteLine("\n--- ORDER RECEIPT ---");
        Console.WriteLine($"Item:     {itemName}");
        Console.WriteLine($"Quantity: {quantity}");
        Console.WriteLine($"Total:    £{totalCost:F2}");
    }
}
