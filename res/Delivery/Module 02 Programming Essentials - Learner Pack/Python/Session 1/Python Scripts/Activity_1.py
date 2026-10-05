# Goal: Log a task and print a success message if it's not exit.
task_name = input("Enter task name: ")

if task_name != "exit":
print(f"Task '{task_name}' has been successfully logged.")

# Goal: Initialize a tracker and add time to it.
total_duration = 0

task_time = int(input("Enter task duration in minutes: "))
total_time = total_duration + task_time

print(f"Total time logged: {total_duration} minutes")

# Goal: Add a flat setup time of 15 minutes to any logged task.
task_duration = input("Enter task duration in minutes: ")
setup_time = 15

final_time = task_duration + setup_time

print(f"Total time with setup: {final_time} minutes")