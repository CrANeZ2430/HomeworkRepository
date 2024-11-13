using System.Text;

string answer;
StringBuilder reportBuilder = new StringBuilder();

while (true)
{
    reportBuilder.Append("\nYour report:");
    Console.ForegroundColor = ConsoleColor.Blue;
    for (int i = 0; i < 3; i++)
    {
        Console.Write($"Enter your {(ReportContents)i}: ");
        reportBuilder.Append($"\n{Console.ReadLine()}");
    }
    Console.ResetColor();
    
    Console.WriteLine(reportBuilder.ToString());
    
    Console.ForegroundColor = ConsoleColor.Green;
    while (true)
    {
        Console.Write("\nDo you want to rework your report? (y/n): ");
        answer = Console.ReadLine();

        if (answer.ToLower() == "y" || answer.ToLower() == "n")
        {
            break;
        }
    }
    
    if (answer == "y")
    {
        reportBuilder.Clear();
        Console.ResetColor();
        Console.Clear();
    }
    else
    {
        Console.WriteLine("Your report is published");
        break;
    }
}

enum ReportContents
{
    Headline,
    Date,
    Events
}