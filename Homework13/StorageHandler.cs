namespace Homework13;

public static class StorageHandler
{
    private const string rootPath = @"C:\Temp";
    private static bool IsCreatedDirectory { get; set; }
    
    public static void SaveTasks(List<UserTask> tasksList)
    {
        IsCreatedDirectory = !Directory.Exists(rootPath + @"\TasksManager\Tasks.txt");
        if (TasksHandler.GetTasksList().Count == 0)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            File.WriteAllText(rootPath + @"\TasksManager\Tasks.txt", "");
            Console.WriteLine("You saved 0 tasks");
            Console.ResetColor();
            return;
        }
        Console.ForegroundColor = ConsoleColor.Green;
        if (!IsCreatedDirectory)
        {
            Directory.CreateDirectory(rootPath + @"\TasksManager");
            File.Create(rootPath + @"\TasksManager\Tasks.txt").Close();
            IsCreatedDirectory = true;
            Console.WriteLine("Created directory: " + rootPath + @"\TasksManager\Tasks.txt");
        }

        File.WriteAllText(rootPath + @"\TasksManager\Tasks.txt", "");
        foreach (UserTask task in tasksList)
        {
            File.AppendAllText(rootPath + @"\TasksManager\Tasks.txt", task.Description + Environment.NewLine);
            File.AppendAllText(rootPath + @"\TasksManager\Tasks.txt", (int)task.Status + Environment.NewLine);
        }
        Console.WriteLine("All tasks have been saved");
        Console.ResetColor();
    }

    public static void LoadTasks(List<UserTask> tasksList)
    {
        var taskStorage = File.ReadAllLines(rootPath + @"\TasksManager\Tasks.txt").ToList();
        if (taskStorage.Count == 0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("You have no tasks to load");
            Console.ResetColor();
            return;
        }
        var taskDescriptions = taskStorage.Where(s => s != "0" && s != "1").ToList();
        var stringStatusList = taskStorage.Where(s => s == "0" || s == "1").ToList();
        var statusesList = new List<TaskStatus>();
        foreach (var status in stringStatusList)
        {
            statusesList.Add((TaskStatus)int.Parse(status));
        }
        
        for (int i = 0; i < taskDescriptions.Count; i++)
        {
            tasksList.Add(new UserTask(taskDescriptions[i], statusesList[i]));
        }
        
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Task have been loaded");
        Console.ResetColor();
    }
}