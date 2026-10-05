public class Bug1 {
    public static void main(String[] args) {
        // Task: Print a countdown from 3 to 1 for a game start.
        // Error Classification: LOGIC ERROR (Runs forever without crashing)

        int countdown = 3;

        while (countdown > 0) {
            System.out.println("Game starting in " + countdown + "...");
            // Hint: Trace what happens to the value of 'countdown' over time.
        }
    }
}
