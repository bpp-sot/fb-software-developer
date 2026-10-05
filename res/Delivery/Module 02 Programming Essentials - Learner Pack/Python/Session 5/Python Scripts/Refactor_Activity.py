# Unstructured script with repetitive code and bad variable naming
p1 = 120.00
p2 = 45.00
p3 = 250.00

# Process item 1
if p1 > 100:
    d1 = p1 * 0.10
else:
    d1 = 0
f1 = p1 - d1
t1 = f1 * 1.20
print(f"Item 1 Final: £{t1:.2f}")

# Process item 2 (Duplicate code block)
if p2 > 100:
    d2 = p2 * 0.10
else:
    d2 = 0
f2 = p2 - d2
t2 = f2 * 1.20
print(f"Item 2 Final: £{t2:.2f}")

# Process item 3 (Duplicate code block)
if p3 > 100:
    d3 = p3 * 0.10
else:
    d3 = 0
f3 = p3 - d3
t3 = f3 * 1.20
print(f"Item 3 Final: £{t3:.2f}")
