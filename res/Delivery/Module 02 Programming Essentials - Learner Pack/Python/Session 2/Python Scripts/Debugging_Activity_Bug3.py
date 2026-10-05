# Task: Allow entry if user is 18+ and has a ticket.
# BUG: Unnecessary deep nesting makes code hard to read and maintain.
age = 20
has_ticket = True

if age >= 18:
    if has_ticket == True:
        print("Allowed entry.")
    else:
        print("Denied entry: Missing ticket.")
else:
    print("Denied entry: Underage.")

