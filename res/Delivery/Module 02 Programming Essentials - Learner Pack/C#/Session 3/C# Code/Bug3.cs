using System;

class Bug3
{
    static void Main(string[] args)
    {
        // Task: Add up a running score multiplier across 4 rounds.
        // Error Classification: LOGIC ERROR (Runs fine, but outputs the wrong math)

        int[] rounds = { 100, 250, 150, 300 };
        int totalScore = 0;  // declared outside, but reset happens inside the loop below

        foreach (int score in rounds)
        {
            totalScore = 0;  // Hint: Trace the lifespan of this variable
            totalScore += score;
            Console.WriteLine($"Round processed. Current subtotal: {totalScore}");
        }

        Console.WriteLine($"Final Total Score: {totalScore}");
    }
}
