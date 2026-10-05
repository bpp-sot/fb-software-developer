# Initialize database entry
server = {"host": "192.168.1.1", "status": "Online"}

# 1. Add a new key "port" with the value 8080
server["port"] = 8080

# 2. Update the "status" key to "Maintenance" (Overwrites existing value)
server["status"] = "Maintenance"

# 3. Access and print the "host" value using its key
extracted_host = server["host"]
print(f"Extracted Host Address: {extracted_host}")

# Expected Output: {'host': '192.168.1.1', 'status': 'Maintenance', 'port': 8080}
print(f"Updated Server Data: {server}")
