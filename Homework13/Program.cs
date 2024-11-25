using Homework13;

List<UserTask> tasksList = new List<UserTask>();

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("1 - Add task\n2 - Set as done\n3 - Remove task\n4 - Modify task\n5 - Display task");
while (true)
{
    SelectAction();
}

void SelectAction()
{
    EditTaskType editTaskType;
    
    while (true)
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write("\nEnter action number: ");
        string input = Console.ReadLine()!;
        if (int.TryParse(input, out int actionNumber) && actionNumber > 0 && actionNumber <= 5)
        {
            editTaskType = (EditTaskType)actionNumber;
            Console.ResetColor();
            break;
        }
    }

    switch (editTaskType)
    {
        case EditTaskType.Add:
            AddTask();
            break;
        case EditTaskType.SetAsDone:
            EditTask(EditTaskType.SetAsDone);
            break;
        case EditTaskType.Remove:
            EditTask(EditTaskType.Remove);
            break;
        case EditTaskType.Modify:
            EditTask(EditTaskType.Modify);
            break;
        case EditTaskType.Display:
            DisplayTasks();
            break;
    }
}

void AddTask()
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
}

void EditTask(EditTaskType editTaskType)
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
        case EditTaskType.SetAsDone:
            tasksList[taskIndex - 1].SetTaskAsDone();
            break;
        case EditTaskType.Remove:
            tasksList.RemoveAt(taskIndex - 1);
            break;
        case EditTaskType.Modify:
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

void DisplayTasks()
{
    if (tasksList.Count == 0)
    {
        Console.ForegroundColor = ConsoleColor.Blue;
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
        Console.Write($"{tasksList[i]} | ");
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