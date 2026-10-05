public class DebuggingActivityBug2 {
    public static void main(String[] args) {
        // Task: Assess movie ticket prices based on age.
        // BUG: This code completely breaks at specific ages due to missing boundaries.
        int age = 12;

        if (age > 12) {
            System.out.println("Ticket Price: £10 (Adult)");
        } else if (age < 12) {
            System.out.println("Ticket Price: £5 (Child)");
        }
        // Hint: What happens if someone is exactly 12? Or if input is negative?
    }
}
