string sourcePath;
string destinationPath;

while (true)
{
    while (true)
    {
        Console.Write("Enter source file path: ");
        sourcePath = Console.ReadLine()!;
        if (!File.Exists(sourcePath))
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("File doesn't exist!");
            Console.ResetColor();
            continue;
        }

        break;
    }

    while (true)
    {
        Console.Write("Enter source file path: ");
        destinationPath = Console.ReadLine()!;
        if (!File.Exists(destinationPath))
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("File doesn't exist!");
            Console.ResetColor();
            continue;
        }

        break;
    }

    if (sourcePath == destinationPath)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Your paths are the same!\n");
        Console.ResetColor();
        continue;
    }
    break;
}

CopyToFile(sourcePath, destinationPath);

void CopyToFile(string sourceFile, string destinationFile)
{
    string text = File.ReadAllText(sourceFile);
    File.WriteAllText(destinationFile, text);
    
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"\nText {text} was successfully copied!");
    Console.ResetColor();
}