# Setup mock database states
database_username = "alice123"
database_password = "SecurePassword7"

# Input test variables (Change these to test different paths)
input_username = "alice123"
input_password = "WrongPassword"
failed_attempts = 3  # Triggers lock out first

# Specific-to-general security logic
if failed_attempts >= 3:
    print("Access Denied: Account is locked out due to too many failed attempts.")
elif input_username != database_username:
    print("Access Denied: Incorrect username.")
elif input_password != database_password:
    print("Access Denied: Incorrect password.")
else:
    print("Access Granted: Welcome back!")