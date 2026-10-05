import java.util.LinkedHashMap;
import java.util.Map;

public class Task2 {
    public static void main(String[] args) {
        // Initialize database entry
        // NOTE: LinkedHashMap is used instead of HashMap to preserve insertion
        // order, matching Python's dict behaviour (Python 3.7+ dicts keep
        // insertion order; a plain Java HashMap does not).
        Map<String, Object> server = new LinkedHashMap<>();
        server.put("host", "192.168.1.1");
        server.put("status", "Online");

        // 1. Add a new key "port" with the value 8080
        server.put("port", 8080);

        // 2. Update the "status" key to "Maintenance" (Overwrites existing value)
        server.put("status", "Maintenance");

        // 3. Access and print the "host" value using its key
        Object extractedHost = server.get("host");
        System.out.println("Extracted Host Address: " + extractedHost);

        // Expected Output: {host=192.168.1.1, status=Maintenance, port=8080}
        System.out.println("Updated Server Data: " + server);
    }
}
