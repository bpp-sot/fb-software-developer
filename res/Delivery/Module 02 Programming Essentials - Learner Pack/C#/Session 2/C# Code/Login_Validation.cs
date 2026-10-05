using System;

class LoginValidation
{
    static void Main(string[] args)
    {
        // Setup mock database states
        string databaseUsername = "alice123";
        string databasePassword = "SecurePassword7";

        // Input test variables (Change these to test different paths)
        string inputUsername = "alice123";
        string inputPassword = "WrongPassword";
        int failedAttempts = 3;  // Triggers lock out first

        // Specific-to-general security logic
        if (failedAttempts >= 3)
        {
            Console.WriteLine("Access Denied: Account is locked out due to too many failed attempts.");
        }
        else if (inputUsername != databaseUsername)
        {
            Console.WriteLine("Access Denied: Incorrect username.");
        }
        else if (inputPassword != databasePassword)
        {
            Console.WriteLine("Access Denied: Incorrect password.");
        }
        else
        {
            Console.WriteLine("Access Granted: Welcome back!");
        }
    }
}
