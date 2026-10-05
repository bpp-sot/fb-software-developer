using System;

class Bug2
{
    static void Main(string[] args)
    {
        // Task: Loop through a list of servers and check their status.
        // Error Classification: RUNTIME ERROR (Crashes the program during execution)

        string[] servers = { "Server_Alpha", "Server_Beta", "Server_Gamma" };
        int totalServers = servers.Length;  // This evaluates to 3

        // Loop through using individual index counts
        for (int index = 0; index < totalServers + 1; index++)
        {
            Console.WriteLine($"Checking status for: {servers[index]}");
        }
    }
}
