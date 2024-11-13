string userInput;

while (true)
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.Write("Enter your words (with comas): ");
    userInput = Console.ReadLine();

    if (userInput.Length != 0 && userInput.Contains(','))
    {
        Console.ResetColor();
        break;
    }
    Console.Clear();
}

string[] processedUserInput = userInput.Split(',').Where(x => !string.IsNullOrWhiteSpace(x)).ToArray();
Console.WriteLine("Your words:");
for (int i = 0; i < processedUserInput.Length; i++)
{
    Console.Write(processedUserInput[i].Trim());
    if (i != processedUserInput.Length - 1)
    {
        Console.Write(",");
    }
}
