using System;
using System.Collections.Generic;

class Task1
{
    static void Main(string[] args)
    {
        // Initialize collection
        List<string> inventory = new List<string> { "Laptop", "Monitor", "Keyboard" };

        // 1. Add "Mouse" to the end of the inventory list
        inventory.Add("Mouse");

        // 2. Remove "Monitor" from the collection
        inventory.Remove("Monitor");

        // 3. Update the first item in the list to "Premium Laptop" (Using zero-indexing)
        inventory[0] = "Premium Laptop";

        // Expected Output: [Premium Laptop, Keyboard, Mouse]
        Console.WriteLine($"Updated Inventory: [{string.Join(", ", inventory)}]");
    }
}
