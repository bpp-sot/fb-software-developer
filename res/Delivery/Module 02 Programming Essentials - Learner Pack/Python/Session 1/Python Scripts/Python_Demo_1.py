# 1. Variables and Data Types
item_name = "Cappuccino"
item_price = 4.50

# 2. Interactive Input
quantity_str = input(f"How many {item_name}s would you like? ")

# 3. Type Conversion
quantity = int(quantity_str)

# 4. Correct Syntax & Formatting
total_cost = item_price * quantity
print("\n--- ORDER RECEIPT ---")
print(f"Item:     {item_name}")
print(f"Quantity: {quantity}")
print(f"Total:    £{total_cost:.2f}")