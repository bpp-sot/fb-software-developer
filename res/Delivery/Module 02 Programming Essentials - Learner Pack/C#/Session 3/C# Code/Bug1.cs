using System;

class Bug1
{
    static void Main(string[] args)
    {
        // Task: Print a countdown from 3 to 1 for a game start.
        // Error Classification: LOGIC ERROR (Runs forever without crashing)

        int countdown = 3;

        while (countdown > 0)
        {
            Console.WriteLine($"Game starting in {countdown}...");
            // Hint: Trace what happens to the value of 'countdown' over time.
        }
    }
}
