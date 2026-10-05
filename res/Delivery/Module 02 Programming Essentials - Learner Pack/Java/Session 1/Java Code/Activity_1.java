import java.util.Scanner;

public class Activity1 {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        // Goal: Log a task and print a success message if it's not exit.
        System.out.print("Enter task name: ");
        String taskName = scanner.nextLine()

        if (!taskName.equals("exit")) {
            System.out.println("Task '" + taskName + "' has been successfully logged.");
        }

        // Goal: Initialize a tracker and add time to it.
        int totalDuration = 0;

        System.out.print("Enter task duration in minutes: ");
        int taskTime = Integer.parseInt(scanner.nextLine());
        int totalTime = totalDuration + taskTime;

        System.out.println("Total time logged: " + totalDuration + " minutes");

        // Goal: Add a flat setup time of 15 minutes to any logged task.
        System.out.print("Enter task duration in minutes: ");
        String taskDuration = scanner.nextLine();
        int setupTime = 15;

        int finalTime = taskDuration + setupTime;

        System.out.println("Total time with setup: " + finalTime + " minutes");
    }
}
