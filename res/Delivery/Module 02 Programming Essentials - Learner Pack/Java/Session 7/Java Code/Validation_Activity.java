import java.io.*;
import java.util.Scanner;

public class ValidationActivity {

    // =====================================================================
    // THE SYSTEM UNDER TEST (A Simple Event Ticketing Gateway)
    // Intentional Behavior Rule: Ages 18-120 pass, under 18 fail.
    // Negative values or text inputs should be caught gracefully.
    // =====================================================================
    /** Evaluates entry eligibility based on age criteria rules. */
    static String validateTicketHolder(String ageInput) {
        try {
            // Convert input to integer
            int age = Integer.parseInt(ageInput);

            // Operational criteria logic checks
            if (age < 0 || age > 120) {
                return "REJECTED: Out-of-bounds numerical age limit";
            } else if (age >= 18) {
                return "ALLOWED: Criteria fully met";
            } else {
                return "REJECTED: Underage barrier exception";
            }

        } catch (NumberFormatException e) {
            return "ERROR: Non-numeric data type detected";
        }
    }

    // =====================================================================
    // AUTOMATED VALIDATION LOG ENGINE
    // =====================================================================
    static final String LOG_FILENAME = "validation_log.csv";
    static Scanner scanner = new Scanner(System.in);

    /** Creates the validation spreadsheet with column headers if missing. */
    static void initializeLogFile() throws IOException {
        File file = new File(LOG_FILENAME);
        if (!file.exists()) {
            try (PrintWriter writer = new PrintWriter(new FileWriter(file))) {
                writer.println("Test ID,Test Category,Input Data,Expected Outcome,Actual Result,Status");
            }
            System.out.println("\uD83D\uDCC1 Initialised clean audit log spreadsheet: " + LOG_FILENAME);
        }
    }

    /** Appends a new verification row to the CSV file record. */
    static void appendValidationRecord(String testId, String category, String inputData, String expected, String actual, String status) throws IOException {
        try (PrintWriter writer = new PrintWriter(new FileWriter(LOG_FILENAME, true))) {
            writer.println(csvEscape(testId) + "," + csvEscape(category) + "," + csvEscape(inputData) + ","
                    + csvEscape(expected) + "," + csvEscape(actual) + "," + csvEscape(status));
        }
        System.out.println("Step recorded successfully into tracking log.");
    }

    static String csvEscape(String value) {
        if (value.contains(",") || value.contains("\"")) {
            return "\"" + value.replace("\"", "\"\"") + "\"";
        }
        return value;
    }

    // =====================================================================
    // INTERACTIVE TESTING HARNESS INTERFACE
    // =====================================================================
    public static void main(String[] args) throws IOException {
        initializeLogFile();
        System.out.println("\n================== QA VALIDATION INTERFACE ==================");
        System.out.println("Use this terminal interface to run inputs and compile evidence.");
        System.out.println("Type 'exit' at any prompt to terminate the session.");
        System.out.println("=============================================================\n");

        int testCounter = 1;

        while (true) {
            System.out.printf("--- Running Test Case ID: TC-%02d ---%n", testCounter);

            // 1. Gather Test Parameters and Categorization
            System.out.println("Select Category: 1. Normal | 2. Edge | 3. Invalid Input");
            System.out.print("Choice (1-3) or 'exit': ");
            String catChoice = scanner.nextLine().strip();
            if (catChoice.equalsIgnoreCase("exit")) break;

            String category;
            switch (catChoice) {
                case "1": category = "Normal"; break;
                case "2": category = "Edge"; break;
                case "3": category = "Invalid Input"; break;
                default: category = "Unknown"; break;
            }

            // 2. Gather Test Assertions
            System.out.print("Enter the Input Data to send to code: ");
            String inputData = scanner.nextLine().strip();
            if (inputData.equalsIgnoreCase("exit")) break;

            System.out.print("Enter the Expected Outcome (Your Prediction): ");
            String expected = scanner.nextLine().strip();
            if (expected.equalsIgnoreCase("exit")) break;

            // 3. Fire Test Against Code Engine and Harvest Actual State
            String actual = validateTicketHolder(inputData);
            System.out.println("\n\u26A1 CODE RUNTIME EXECUTION OUTPUT: \"" + actual + "\"");

            // 4. Compare State to Assign Pass/Fail Verification Score
            System.out.println("\nCompare your prediction against the code runtime engine:");
            System.out.println(" -> Expected: " + expected);
            System.out.println(" -> Actual  : " + actual);
            System.out.print("Does the code match your expected design? (y = PASS / n = FAIL): ");
            String statusChoice = scanner.nextLine().strip().toLowerCase();
            if (statusChoice.equalsIgnoreCase("exit")) break;

            String status = statusChoice.equals("y") ? "PASS" : "FAIL";
            System.out.println("Result set as: " + status + " \n");

            // 5. Commit Row Entry Into Spreadsheet Store
            appendValidationRecord(String.format("TC-%02d", testCounter), category, inputData, expected, actual, status);

            testCounter += 1;
            System.out.println("-".repeat(60) + "\n");
        }

        System.out.println("\nSession ended. Share '" + LOG_FILENAME + "' as your workbook evidence!");
    }
}
