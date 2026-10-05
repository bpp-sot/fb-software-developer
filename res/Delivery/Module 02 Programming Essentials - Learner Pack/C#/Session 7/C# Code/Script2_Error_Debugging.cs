using System;
using System.Collections.Generic;

class Script2_Error_Debugging
{
    // Task: Read a list of server ping response times and calculate the average.
    // Error Classification: RUNTIME ERROR (Crashes during execution under specific conditions)
    //
    // IMPORTANT LANGUAGE DIFFERENCE: Unlike Python, C# does NOT throw an
    // exception for 0.0 / 0 with double values — it silently produces NaN
    // ("Not a Number") instead of crashing. This is arguably a MORE dangerous
    // bug than Python's version, since the program keeps running with bad
    // data instead of stopping immediately. See the Fixed version for the
    // correct guard clause regardless of this difference.

    static double GetAveragePing(List<double> pingList)
    {
        double totalPing = 0.0;
        foreach (double ping in pingList)
        {
            totalPing += ping;
        }

        double average = totalPing / pingList.Count;
        return average;
    }

    static void Main(string[] args)
    {
        // Test Case A: Works perfectly
        List<double> activePings = new List<double> { 12.5, 45.0, 22.1 };
        Console.WriteLine($"Average ping: {GetAveragePing(activePings)}ms");

        // Test Case B: Crashes the system (in Python) / silently produces NaN (in C#)
        List<double> offlinePings = new List<double>();
        Console.WriteLine($"Average ping: {GetAveragePing(offlinePings)}ms");
    }
}
