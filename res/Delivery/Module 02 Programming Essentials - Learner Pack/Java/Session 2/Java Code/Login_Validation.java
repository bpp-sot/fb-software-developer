public class LoginValidation {
    public static void main(String[] args) {
        // Setup mock database states
        String databaseUsername = "alice123";
        String databasePassword = "SecurePassword7";

        // Input test variables (Change these to test different paths)
        String inputUsername = "alice123";
        String inputPassword = "WrongPassword";
        int failedAttempts = 3;  // Triggers lock out first

        // Specific-to-general security logic
        if (failedAttempts >= 3) {
            System.out.println("Access Denied: Account is locked out due to too many failed attempts.");
        } else if (!inputUsername.equals(databaseUsername)) {
            System.out.println("Access Denied: Incorrect username.");
        } else if (!inputPassword.equals(databasePassword)) {
            System.out.println("Access Denied: Incorrect password.");
        } else {
            System.out.println("Access Granted: Welcome back!");
        }
    }
}
