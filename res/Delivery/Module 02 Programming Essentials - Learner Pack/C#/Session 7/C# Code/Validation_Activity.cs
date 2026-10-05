using System;
using System.IO;

class ValidationActivity
{
    // =====================================================================
    // THE SYSTEM UNDER TEST (A Simple Event Ticketing Gateway)
    // Intentional Behavior Rule: Ages 18-120 pass, under 18 fail.
    // Negative values or text inputs should be caught gracefully.
    // =====================================================================
    /// <summary>Evaluates entry eligibility based on age criteria rules.</summary>
    static string ValidateTicketHolder(string ageInput)
    {
        // Convert input to integer
        if (!int.TryParse(ageInput, out int age))
        {
            return "ERROR: Non-numeric data type detected";
        }

        // Operational criteria logic checks
        if (age < 0 || age > 120)
        {
            return "REJECTED: Out-of-bounds numerical age limit";
        }
        else if (age >= 18)
        {
            return "ALLOWED: Criteria fully met";
        }
        else
        {
            return "REJECTED: Underage barrier exception";
        }
    }

    // =====================================================================
    // AUTOMATED VALIDATION LOG ENGINE
    // =====================================================================
    const string LogFilename = "validation_log.csv";

    /// <summary>Creates the validation spreadsheet with column headers if missing.</summary>
    static void InitializeLogFile()
    {
        if (!File.Exists(LogFilename))
        {
            File.WriteAllText(LogFilename, "Test ID,Test Category,Input Data,Expected Outcome,Actual Result,Status\n");
            Console.WriteLine($"\U0001F4C1 Initialised clean audit log spreadsheet: {LogFilename}");
        }
    }

    /// <summary>Appends a new verification row to the CSV file record.</summary>
    static void AppendValidationRecord(string testId, string category, string inputData, string expected, string actual, string status)
    {
        string row = $"{CsvEscape(testId)},{CsvEscape(category)},{CsvEscape(inputData)},{CsvEscape(expected)},{CsvEscape(actual)},{CsvEscape(status)}\n";
        File.AppendAllText(LogFilename, row);
        Console.WriteLine("Step recorded successfully into tracking log.");
    }

    static string CsvEscape(string value)
    {
        if (value.Contains(",") || value.Contains("\""))
        {
            return "\"" + value.Replace("\"", "\"\"") + "\"";
        }
        return value;
    }

    // =====================================================================
    // INTERACTIVE TESTING HARNESS INTERFACE
    // =====================================================================
    static void Main(string[] args)
    {
        InitializeLogFile();
        Console.WriteLine("\n================== QA VALIDATION INTERFACE ==================");
        Console.WriteLine("Use this terminal interface to run inputs and compile evidence.");
        Console.WriteLine("Type 'exit' at any prompt to terminate the session.");
        Console.WriteLine("=============================================================\n");

        int testCounter = 1;

        while (true)
        {
            Console.WriteLine($"--- Running Test Case ID: TC-{testCounter:D2} ---");

            // 1. Gather Test Parameters and Categorization
            Console.WriteLine("Select Category: 1. Normal | 2. Edge | 3. Invalid Input");
            Console.Write("Choice (1-3) or 'exit': ");
            string catChoice = Console.ReadLine().Trim();
            if (catChoice.ToLower() == "exit") break;

            string category;
            if (catChoice == "1") category = "Normal";
            else if (catChoice == "2") category = "Edge";
            else if (catChoice == "3") category = "Invalid Input";
            else category = "Unknown";

            // 2. Gather Test Assertions
            Console.Write("Enter the Input Data to send to code: ");
            string inputData = Console.ReadLine().Trim();
            if (inputData.ToLower() == "exit") break;

            Console.Write("Enter the Expected Outcome (Your Prediction): ");
            string expected = Console.ReadLine().Trim();
            if (expected.ToLower() == "exit") break;

            // 3. Fire Test Against Code Engine and Harvest Actual State
            string actual = ValidateTicketHolder(inputData);
            Console.WriteLine($"\n\u26A1 CODE RUNTIME EXECUTION OUTPUT: \"{actual}\"");

            // 4. Compare State to Assign Pass/Fail Verification Score
            Console.WriteLine("\nCompare your prediction against the code runtime engine:");
            Console.WriteLine($" -> Expected: {expected}");
            Console.WriteLine($" -> Actual  : {actual}");
            Console.Write("Does the code match your expected design? (y = PASS / n = FAIL): ");
            string statusChoice = Console.ReadLine().Trim().ToLower();
            if (statusChoice == "exit") break;

            string status = statusChoice == "y" ? "PASS" : "FAIL";
            Console.WriteLine($"Result set as: {status} \n");

            // 5. Commit Row Entry Into Spreadsheet Store
            AppendValidationRecord($"TC-{testCounter:D2}", category, inputData, expected, actual, status);

            testCounter += 1;
            Console.WriteLine(new string('-', 60) + "\n");
        }

        Console.WriteLine($"\nSession ended. Share '{LogFilename}' as your workbook evidence!");
    }
}
