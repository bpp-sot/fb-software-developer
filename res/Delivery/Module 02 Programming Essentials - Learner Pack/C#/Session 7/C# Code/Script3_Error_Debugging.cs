using System;

class Script3_Error_Debugging
{
    // Task: Flag students who have failed a mock exam (Score strictly below 50).
    // Error Classification: LOGIC ERROR (Runs without crashing, but flags the wrong students)

    static string CheckPassStatus(int studentScore)
    {
        // If the score is less than 50, they fail
        if (studentScore > 50)
        {
            return "Fail";
        }
        else
        {
            return "Pass";
        }
    }

    static void Main(string[] args)
    {
        // Verification Tracing
        Console.WriteLine($"Score 35 Result: {CheckPassStatus(35)}");  // Should be Fail
        Console.WriteLine($"Score 85 Result: {CheckPassStatus(85)}");  // Should be Pass
    }
}
