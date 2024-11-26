namespace Homework13;

public static class TasksHandler
{
    private static List<UserTask> tasksList = new List<UserTask>();
    
    public static void AddTask()
    {
        while (true)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Enter task: ");
            string input = Console.ReadLine()!;
            if (input != "")
            {
                tasksList.Add(new UserTask(input.Trim()));
                Console.ResetColor();
                break;
            }
        }
        DisplayTasks();
    }

    public static void EditTask(EditTaskType editTaskType)
    {
        if (tasksList.Count == 0)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("You don't have any tasks to edit");
            Console.ResetColor();
            return;
        }

        int taskIndex;

        while (true)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write($"Enter task number to {editTaskType.ToString().ToLower()}: ");
            string input = Console.ReadLine()!;
            if (int.TryParse(input, out taskIndex) && taskIndex > 0 && taskIndex <= tasksList.Count)
            {
                break;
            }
        }

        switch (editTaskType)
        {
            case EditTaskType.Mark:
                if (!tasksList[taskIndex - 1].CanModify)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Your task is already finished");
                    Console.ResetColor();
                    return;
                }
                tasksList[taskIndex - 1].SetTaskAsDone();
                break;
            case EditTaskType.Remove:
                tasksList.RemoveAt(taskIndex - 1);
                break;
            case EditTaskType.Modify:
                tasksList.RemoveAt(taskIndex - 1);
                while (true)
                {
                    Console.Write("Enter new task: ");
                    string inputTask = Console.ReadLine()!;
                    if (inputTask != "")
                    {
                        tasksList.Add(new UserTask(inputTask));
                        break;
                    }
                }
                break;
        }

        Console.ResetColor();
        DisplayTasks();
    }

    public static void DisplayTasks()
    {
        if (tasksList.Count == 0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("You don't have any tasks to display");
            Console.ResetColor();
            return;
        }

        int biggestDescriptionLength = 0;
        int additionalPads = 17;

        foreach (var task in tasksList)
        {
            if (task.Description.Length > biggestDescriptionLength)
            {
                biggestDescriptionLength = task.Description.Length;
            }
        }

        for (int i = 0; i < tasksList.Count; i++)
        {
            Console.Write($"{i + 1} | ");
            if (tasksList[i].Description.Length == biggestDescriptionLength)
            {
                Console.Write(tasksList[i].Description);
            }
            else
            {
                Console.Write(tasksList[i].Description.PadRight(biggestDescriptionLength));
            }

            Console.WriteLine($" | {tasksList[i].Status}");


            if (i != tasksList.Count - 1)
            {
                Console.WriteLine("-".PadRight(additionalPads + biggestDescriptionLength, '-'));
            }
        }
    }

    public static List<UserTask> GetTasksList()
    {
        return tasksList;
    }
}