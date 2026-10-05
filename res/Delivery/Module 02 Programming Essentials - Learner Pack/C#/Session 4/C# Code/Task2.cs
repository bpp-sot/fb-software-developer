using System;
using System.Collections.Generic;
using System.Linq;

class Task2
{
    static void Main(string[] args)
    {
        // Initialize database entry
        var server = new Dictionary<string, object>
        {
            { "host", "192.168.1.1" },
            { "status", "Online" }
        };

        // 1. Add a new key "port" with the value 8080
        server["port"] = 8080;

        // 2. Update the "status" key to "Maintenance" (Overwrites existing value)
        server["status"] = "Maintenance";

        // 3. Access and print the "host" value using its key
        object extractedHost = server["host"];
        Console.WriteLine($"Extracted Host Address: {extractedHost}");

        // Expected Output: {host: 192.168.1.1, status: Maintenance, port: 8080}
        string formatted = string.Join(", ", server.Select(kv => $"{kv.Key}: {kv.Value}"));
        Console.WriteLine($"Updated Server Data: {{{formatted}}}");
    }
}
