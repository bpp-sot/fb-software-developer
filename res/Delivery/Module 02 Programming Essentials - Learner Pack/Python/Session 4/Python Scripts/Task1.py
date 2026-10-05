# Initialize collection
inventory = ["Laptop", "Monitor", "Keyboard"]

# 1. Add "Mouse" to the end of the inventory list
inventory.append("Mouse")

# 2. Remove "Monitor" from the collection
inventory.remove("Monitor")

# 3. Update the first item in the list to "Premium Laptop" (Using zero-indexing)
inventory[0] = "Premium Laptop"

# Expected Output: ['Premium Laptop', 'Keyboard', 'Mouse']
print(f"Updated Inventory: {inventory}")
