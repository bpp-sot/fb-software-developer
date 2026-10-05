# Task: Loop through a list of servers and check their status.
# Error Classification: RUNTIME ERROR (Crashes the program during execution)

servers = ["Server_Alpha", "Server_Beta", "Server_Gamma"]
total_servers = len(servers)  # This evaluates to 3

# Loop through using individual index counts
for index in range(0, total_servers + 1):
    print(f"Checking status for: {servers[index]}")
