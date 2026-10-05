import java.util.ArrayList;
import java.util.List;

public class Task1 {
    public static void main(String[] args) {
        // Initialize collection
        List<String> inventory = new ArrayList<>(List.of("Laptop", "Monitor", "Keyboard"));

        // 1. Add "Mouse" to the end of the inventory list
        inventory.add("Mouse");

        // 2. Remove "Monitor" from the collection
        inventory.remove("Monitor");

        // 3. Update the first item in the list to "Premium Laptop" (Using zero-indexing)
        inventory.set(0, "Premium Laptop");

        // Expected Output: [Premium Laptop, Keyboard, Mouse]
        System.out.println("Updated Inventory: " + inventory);
    }
}
