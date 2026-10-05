public class SimpleEligibilityChecker {
    public static void main(String[] args) {
        // Input test variables (Change these to test different paths)
        int userAge = 19;
        boolean hasTicket = true;

        // Multi-variable criteria using logical operators
        if (userAge >= 18 && hasTicket) {
            System.out.println("Entry Allowed: Age verified and valid ticket present.");
        } else if (userAge >= 18 && !hasTicket) {
            System.out.println("Entry Denied: Age verified, but missing a valid ticket.");
        } else {
            System.out.println("Entry Denied: User must be 18 or older.");
        }
    }
}
