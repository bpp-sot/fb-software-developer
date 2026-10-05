using System;

class Activity1
{
    static void Main(string[] args)
    {
        // Goal: Log a task and print a success message if it's not exit.
        Console.Write("Enter task name: ");
        string taskName = Console.ReadLine()

        if (taskName != "exit")
        {
            Console.WriteLine($"Task '{taskName}' has been successfully logged.");
        }

        // Goal: Initialize a tracker and add time to it.
        int totalDuration = 0;

        Console.Write("Enter task duration in minutes: ");
        int taskTime = int.Parse(Console.ReadLine());
        int totalTime = totalDuration + taskTime;

        Console.WriteLine($"Total time logged: {totalDuration} minutes");

        // Goal: Add a flat setup time of 15 minutes to any logged task.
        Console.Write("Enter task duration in minutes: ");
        string taskDuration = Console.ReadLine();
        int setupTime = 15;

        int finalTime = taskDuration + setupTime;

        Console.WriteLine($"Total time with setup: {finalTime} minutes");
    }
}
