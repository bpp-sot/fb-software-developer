public class Bug2 {
    public static void main(String[] args) {
        // Task: Loop through a list of servers and check their status.
        // Error Classification: RUNTIME ERROR (Crashes the program during execution)

        String[] servers = {"Server_Alpha", "Server_Beta", "Server_Gamma"};
        int totalServers = servers.length;  // This evaluates to 3

        // Loop through using individual index counts
        for (int index = 0; index < totalServers + 1; index++) {
            System.out.println("Checking status for: " + servers[index]);
        }
    }
}
