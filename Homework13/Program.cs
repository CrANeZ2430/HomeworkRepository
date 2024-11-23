using Homework13;

List<string> tasksList = new List<string>();

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("1 - Add task\n2 - Remove task\n3 - Modify task\n4 - Display task");
while (true)
{
    SelectAction();
}

void SelectAction()
{
    int actionNumber;
    TaskType taskType;
    
    while (true)
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write("\nEnter action number: ");
        string input = Console.ReadLine()!;
        if (int.TryParse(input, out actionNumber) && actionNumber > 0 && actionNumber <= 4)
        {
            taskType = (TaskType)actionNumber;
            Console.ResetColor();
            break;
        }
        Console.Clear();
    }

    switch (taskType)
    {
        case TaskType.Add:
            AddTask();
            break;
        case TaskType.Remove:
            break;
        case TaskType.Modify:
            break;
        case TaskType.Display:
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
            tasksList.Add(input.Trim());
            Console.ResetColor();
            break;
        }
    }
}

void DisplayTasks()
{
    for (int i = 0; i < tasksList.Count; i++)
    {
        Console.WriteLine(tasksList[i]);
    }
}