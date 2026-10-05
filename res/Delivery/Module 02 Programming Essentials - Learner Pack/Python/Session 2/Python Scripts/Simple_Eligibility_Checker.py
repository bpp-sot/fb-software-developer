# Input test variables (Change these to test different paths)
user_age = 19
has_ticket = True

# Multi-variable criteria using logical operators
if user_age >= 18 and has_ticket:
    print("Entry Allowed: Age verified and valid ticket present.")
elif user_age >= 18 and not has_ticket:
    print("Entry Denied: Age verified, but missing a valid ticket.")
else:
    print("Entry Denied: User must be 18 or older.")