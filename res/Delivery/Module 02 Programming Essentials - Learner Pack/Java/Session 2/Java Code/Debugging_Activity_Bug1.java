public class DebuggingActivityBug1 {
    public static void main(String[] args) {
        // Task: Assign standard school grades based on scores.
        // BUG: Broad conditions are placed at the top, shadowing specific ones.
        int score = 85;

        if (score >= 50) {
            System.out.println("Grade: Pass");
        } else if (score >= 75) {
            System.out.println("Grade: Merit");
        } else if (score >= 90) {
            System.out.println("Grade: Distinction");
        } else {
            System.out.println("Grade: Fail");
        }
    }
}
