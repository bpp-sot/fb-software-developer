# Task: Assess movie ticket prices based on age.
# BUG: This code completely breaks at specific ages due to missing boundaries.
age = 12

if age > 12:
    print("Ticket Price: £10 (Adult)")
elif age < 12:
    print("Ticket Price: £5 (Child)")
# Hint: What happens if someone is exactly 12? Or if input is negative?

