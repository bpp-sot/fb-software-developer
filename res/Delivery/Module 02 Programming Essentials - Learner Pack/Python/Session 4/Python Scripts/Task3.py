# List of server location coordinates (Tuples)
locations = [(54.97, -1.61), (51.50, -0.12), (53.48, -2.24)]

print("--- Iterating Over Collections ---")
# 1. Loop through list and unpack tuple structures natively
for lat, lon in locations:
    print(f"Server Coordinates Found -> Latitude: {lat}, Longitude: {lon}")


print("\n--- The Tuple Immutability Experiment ---")
# 2. Demonstration of the type constraint trap
try:
    first_location = locations[0]
    # Attempting to mutate a locked tuple coordinate
    first_location[0] = 0.0 
except TypeError as error:
    print(f"❌ Safety Catch Active! Python blocked modification with error:\n   {error}")
