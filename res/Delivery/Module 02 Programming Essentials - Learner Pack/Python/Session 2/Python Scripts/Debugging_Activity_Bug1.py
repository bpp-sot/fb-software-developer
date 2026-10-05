# Task: Assign standard school grades based on scores.
# BUG: Broad conditions are placed at the top, shadowing specific ones.
score = 85

if score >= 50:
    print("Grade: Pass")
elif score >= 75:
    print("Grade: Merit")
elif score >= 90:
    print("Grade: Distinction")
else:
    print("Grade: Fail")

