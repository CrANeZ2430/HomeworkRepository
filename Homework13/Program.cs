while (true)
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.Write("Enter number of action: ");
    string input = Console.ReadLine()!;
    if (int.TryParse(input, out int actionNumber) && actionNumber > 0 && actionNumber <= 4)
    {
        Console.ResetColor();
        break;
    }
}