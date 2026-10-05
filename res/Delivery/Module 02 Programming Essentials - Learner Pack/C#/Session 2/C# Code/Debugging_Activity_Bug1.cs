using System;

class DebuggingActivityBug1
{
    static void Main(string[] args)
    {
        // Task: Assign standard school grades based on scores.
        // BUG: Broad conditions are placed at the top, shadowing specific ones.
        int score = 85;

        if (score >= 50)
        {
            Console.WriteLine("Grade: Pass");
        }
        else if (score >= 75)
        {
            Console.WriteLine("Grade: Merit");
        }
        else if (score >= 90)
        {
            Console.WriteLine("Grade: Distinction");
        }
        else
        {
            Console.WriteLine("Grade: Fail");
        }
    }
}
