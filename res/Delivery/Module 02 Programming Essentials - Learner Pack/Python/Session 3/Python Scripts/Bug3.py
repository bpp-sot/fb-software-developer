# Task: Add up a running score multiplier across 4 rounds.
# Error Classification: LOGIC ERROR (Runs fine, but outputs the wrong math)

rounds = [100, 250, 150, 300]

for score in rounds:
    total_score = 0  # Hint: Trace the lifespan of this variable
    total_score += score
    print(f"Round processed. Current subtotal: {total_score}")

print(f"Final Total Score: {total_score}")
