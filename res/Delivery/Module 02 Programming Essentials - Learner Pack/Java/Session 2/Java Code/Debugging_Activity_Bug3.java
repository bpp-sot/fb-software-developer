public class DebuggingActivityBug3 {
    public static void main(String[] args) {
        // Task: Allow entry if user is 18+ and has a ticket.
        // BUG: Unnecessary deep nesting makes code hard to read and maintain.
        int age = 20;
        boolean hasTicket = true;

        if (age >= 18) {
            if (hasTicket == true) {
                System.out.println("Allowed entry.");
            } else {
                System.out.println("Denied entry: Missing ticket.");
            }
        } else {
            System.out.println("Denied entry: Underage.");
        }
    }
}
