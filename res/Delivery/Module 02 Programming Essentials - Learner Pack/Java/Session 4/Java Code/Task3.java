import java.util.ArrayList;
import java.util.List;

public class Task3 {
    // A simple immutable coordinate "record" - Java's answer to a Python tuple
    record Coordinate(double lat, double lon) {}

    public static void main(String[] args) {
        // List of server location coordinates (immutable Coordinate records)
        List<Coordinate> locations = new ArrayList<>(List.of(
                new Coordinate(54.97, -1.61),
                new Coordinate(51.50, -0.12),
                new Coordinate(53.48, -2.24)
        ));

        System.out.println("--- Iterating Over Collections ---");
        // 1. Loop through the list and unpack each Coordinate's fields natively
        for (Coordinate location : locations) {
            System.out.println("Server Coordinates Found -> Latitude: " + location.lat() + ", Longitude: " + location.lon());
        }

        System.out.println("\n--- The Record Immutability Experiment ---");
        // 2. Demonstration of the type constraint trap
        // Java records have no setters at all, so this line simply will not compile:
        //
        //     locations.get(0).lat = 0.0;
        //
        // Uncommenting the line above produces:
        //   error: cannot assign a value to final variable lat
        System.out.println("\u274C Safety Catch Active! Java blocks modification at compile time");
        System.out.println("   because record components are implicitly final and have no setters.");
    }
}
