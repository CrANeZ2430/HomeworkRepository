using Homework13;

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("1 - Add task\n2 - Set as done\n3 - Remove task\n4 - Modify task\n5 - Display task\n6 - Save tasks\n7 - Load tasks");
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
        if (int.TryParse(input, out int actionNumber) && actionNumber > 0 && actionNumber < 8)
        {
            editTaskType = (EditTaskType)actionNumber;
            Console.ResetColor();
            break;
        }
    }

    switch (editTaskType)
    {
        case EditTaskType.Add:
            TasksHandler.AddTask();
            break;
        case EditTaskType.Mark:
            TasksHandler.EditTask(EditTaskType.Mark);
            break;
        case EditTaskType.Remove:
            TasksHandler.EditTask(EditTaskType.Remove);
            break;
        case EditTaskType.Modify:
            TasksHandler.EditTask(EditTaskType.Modify);
            break;
        case EditTaskType.Display:
            TasksHandler.DisplayTasks();
            break;
        case EditTaskType.Save:
            StorageHandler.SaveTasks(TasksHandler.GetTasksList());
            break;
        case EditTaskType.Load:
            StorageHandler.LoadTasks(TasksHandler.GetTasksList());
            break;
    }
}