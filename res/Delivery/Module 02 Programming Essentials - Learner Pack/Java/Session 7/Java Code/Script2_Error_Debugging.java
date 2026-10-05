import java.util.ArrayList;
import java.util.List;

public class Script2_Error_Debugging {
    // Task: Read a list of server ping response times and calculate the average.
    // Error Classification: RUNTIME ERROR (Crashes during execution under specific conditions)
    //
    // IMPORTANT LANGUAGE DIFFERENCE: Unlike Python, Java does NOT throw an
    // exception for 0.0 / 0 with double values — it silently produces NaN
    // ("Not a Number") instead of crashing. This is arguably a MORE dangerous
    // bug than Python's version, since the program keeps running with bad
    // data instead of stopping immediately. See the Fixed version for the
    // correct guard clause regardless of this difference.

    static double getAveragePing(List<Double> pingList) {
        double totalPing = 0.0;
        for (double ping : pingList) {
            totalPing += ping;
        }

        double average = totalPing / pingList.size();
        return average;
    }

    public static void main(String[] args) {
        // Test Case A: Works perfectly
        List<Double> activePings = new ArrayList<>(List.of(12.5, 45.0, 22.1));
        System.out.println("Average ping: " + getAveragePing(activePings) + "ms");

        // Test Case B: Crashes the system (in Python) / silently produces NaN (in Java)
        List<Double> offlinePings = new ArrayList<>();
        System.out.println("Average ping: " + getAveragePing(offlinePings) + "ms");
    }
}
