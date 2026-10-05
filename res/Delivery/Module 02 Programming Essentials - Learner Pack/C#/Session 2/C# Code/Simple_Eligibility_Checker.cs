using System;

class SimpleEligibilityChecker
{
    static void Main(string[] args)
    {
        // Input test variables (Change these to test different paths)
        int userAge = 19;
        bool hasTicket = true;

        // Multi-variable criteria using logical operators
        if (userAge >= 18 && hasTicket)
        {
            Console.WriteLine("Entry Allowed: Age verified and valid ticket present.");
        }
        else if (userAge >= 18 && !hasTicket)
        {
            Console.WriteLine("Entry Denied: Age verified, but missing a valid ticket.");
        }
        else
        {
            Console.WriteLine("Entry Denied: User must be 18 or older.");
        }
    }
}
