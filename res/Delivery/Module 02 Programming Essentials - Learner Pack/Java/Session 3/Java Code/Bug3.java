public class Bug3 {
    public static void main(String[] args) {
        // Task: Add up a running score multiplier across 4 rounds.
        // Error Classification: LOGIC ERROR (Runs fine, but outputs the wrong math)

        int[] rounds = {100, 250, 150, 300};
        int totalScore = 0;  // declared outside, but reset happens inside the loop below

        for (int score : rounds) {
            totalScore = 0;  // Hint: Trace the lifespan of this variable
            totalScore += score;
            System.out.println("Round processed. Current subtotal: " + totalScore);
        }

        System.out.println("Final Total Score: " + totalScore);
    }
}
