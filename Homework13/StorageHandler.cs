namespace Homework13;

public static class StorageHandler
{
    private const string RootPath = @"C:\Temp";
    private static bool IsCreatedFile { get; set; }
    
    public static void SaveTasks(List<UserTask> tasksList)
    {
        IsCreatedFile = File.Exists(RootPath + @"\TasksManager\Tasks.txt");
        Console.ForegroundColor = ConsoleColor.Green;
        
        if (!IsCreatedFile)
        {
            Directory.CreateDirectory(RootPath + @"\TasksManager");
            File.Create(RootPath + @"\TasksManager\Tasks.txt").Close();
            IsCreatedFile = true;
            Console.WriteLine("Created directory: " + RootPath + @"\TasksManager\Tasks.txt");
            Console.ResetColor();
        }
        
        if (TasksHandler.GetTasksList().Count == 0)
        {
            File.WriteAllText(RootPath + @"\TasksManager\Tasks.txt", "");
            Console.WriteLine("You saved 0 tasks");
            Console.ResetColor();
            return;
        }

        File.WriteAllText(RootPath + @"\TasksManager\Tasks.txt", "");
        foreach (UserTask task in tasksList)
        {
            File.AppendAllText(RootPath + @"\TasksManager\Tasks.txt", task.Description + Environment.NewLine);
            File.AppendAllText(RootPath + @"\TasksManager\Tasks.txt", (int)task.Status + Environment.NewLine);
        }
        Console.WriteLine("All tasks have been saved");
        Console.ResetColor();
    }

    public static void LoadTasks(List<UserTask> tasksList)
    {
        var taskStorage = File.ReadAllLines(RootPath + @"\TasksManager\Tasks.txt").ToList();
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
        
        tasksList.Clear();
        for (int i = 0; i < taskDescriptions.Count; i++)
        {
            tasksList.Add(new UserTask(taskDescriptions[i], statusesList[i]));
        }
        
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Task have been loaded");
        Console.ResetColor();
    }
}