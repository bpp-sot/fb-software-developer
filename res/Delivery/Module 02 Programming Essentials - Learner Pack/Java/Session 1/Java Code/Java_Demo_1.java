import java.util.Scanner;

public class JavaDemo1 {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        // 1. Variables and Data Types
        String itemName = "Cappuccino";
        double itemPrice = 4.50;

        // 2. Interactive Input
        System.out.print("How many " + itemName + "s would you like? ");
        String quantityStr = scanner.nextLine();

        // 3. Type Conversion
        int quantity = Integer.parseInt(quantityStr);

        // 4. Correct Syntax & Formatting
        double totalCost = itemPrice * quantity;
        System.out.println("\n--- ORDER RECEIPT ---");
        System.out.println("Item:     " + itemName);
        System.out.println("Quantity: " + quantity);
        System.out.printf("Total:    £%.2f%n", totalCost);
    }
}
