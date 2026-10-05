# Task: Flag students who have failed a mock exam (Score strictly below 50).
# Error Classification: LOGIC ERROR (Runs without crashing, but flags the wrong students)

def check_pass_status(student_score):
    # If the score is less than 50, they fail
    if student_score > 50:
        return "Fail"
    else:
        return "Pass"

# Verification Tracing
print(f"Score 35 Result: {check_pass_status(35)}")  # Should be Fail
print(f"Score 85 Result: {check_pass_status(85)}")  # Should be Pass
