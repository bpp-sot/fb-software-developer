# Task: Read a list of server ping response times and calculate the average.
# Error Classification: RUNTIME ERROR (Crashes during execution under specific conditions)

def get_average_ping(ping_list):
    total_ping = 0.0
    for ping in ping_list:
        total_ping += ping
        
    average = total_ping / len(ping_list)
    return average

# Test Case A: Works perfectly
active_pings = [12.5, 45.0, 22.1]
print(f"Average ping: {get_average_ping(active_pings)}ms")

# Test Case B: Crashes the system
offline_pings = []
print(f"Average ping: {get_average_ping(offline_pings)}ms")
