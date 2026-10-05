public class Script3_Error_Debugging {
    // Task: Flag students who have failed a mock exam (Score strictly below 50).
    // Error Classification: LOGIC ERROR (Runs without crashing, but flags the wrong students)

    static String checkPassStatus(int studentScore) {
        // If the score is less than 50, they fail
        if (studentScore > 50) {
            return "Fail";
        } else {
            return "Pass";
        }
    }

    public static void main(String[] args) {
        // Verification Tracing
        System.out.println("Score 35 Result: " + checkPassStatus(35));  // Should be Fail
        System.out.println("Score 85 Result: " + checkPassStatus(85));  // Should be Pass
    }
}
