using System;
using System.Collections.Generic;

class Task3
{
    // A simple immutable coordinate struct - C#'s answer to a Python tuple
    readonly struct Coordinate
    {
        public double Lat { get; }
        public double Lon { get; }

        public Coordinate(double lat, double lon)
        {
            Lat = lat;
            Lon = lon;
        }
    }

    static void Main(string[] args)
    {
        // List of server location coordinates (immutable Coordinate structs)
        List<Coordinate> locations = new List<Coordinate>
        {
            new Coordinate(54.97, -1.61),
            new Coordinate(51.50, -0.12),
            new Coordinate(53.48, -2.24)
        };

        Console.WriteLine("--- Iterating Over Collections ---");
        // 1. Loop through the list and unpack each Coordinate's fields natively
        foreach (var location in locations)
        {
            Console.WriteLine($"Server Coordinates Found -> Latitude: {location.Lat}, Longitude: {location.Lon}");
        }

        Console.WriteLine("\n--- The Immutability Experiment ---");
        // 2. Demonstration of the type constraint trap
        // Coordinate's properties are read-only (get-only), so this line
        // simply will not compile:
        //
        //     locations[0].Lat = 0.0;
        //
        // Uncommenting the line above produces:
        //   error CS0200: Property or indexer 'Coordinate.Lat' cannot be
        //   assigned to -- it is read only
        Console.WriteLine("\u274C Safety Catch Active! C# blocks modification at compile time");
        Console.WriteLine("   because Coordinate's properties are get-only and have no public setters.");
    }
}
