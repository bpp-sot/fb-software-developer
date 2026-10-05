using System;

class DebuggingActivityBug3
{
    static void Main(string[] args)
    {
        // Task: Allow entry if user is 18+ and has a ticket.
        // BUG: Unnecessary deep nesting makes code hard to read and maintain.
        int age = 20;
        bool hasTicket = true;

        if (age >= 18)
        {
            if (hasTicket == true)
            {
                Console.WriteLine("Allowed entry.");
            }
            else
            {
                Console.WriteLine("Denied entry: Missing ticket.");
            }
        }
        else
        {
            Console.WriteLine("Denied entry: Underage.");
        }
    }
}
