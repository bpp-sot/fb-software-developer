# Input test variable (Change this to test different paths)
order_total = 125.50

# Specific-to-general boundary logic
if order_total >= 100.0:
    discount_percentage = 20
elif order_total >= 50.0:
    discount_percentage = 10
elif order_total >= 0.0:
    discount_percentage = 0
else:
    discount_percentage = 0
    print("Warning: Invalid order total (negative value).")

print(f"Applied Discount: {discount_percentage}%")