string initials;

while (true)
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.Write("Enter your name: ");
    initials = Console.ReadLine();

    if (initials.Length != 0 && initials.Contains(' '))
    {
        Console.ResetColor();
        break;
    }
    Console.Clear();
}

string[] trimmedInput = initials.Split().Where(x => !string.IsNullOrWhiteSpace(x)).ToArray();
Console.WriteLine($"Your initials: {trimmedInput[0]} {trimmedInput[1]}");

if (trimmedInput[0][0] == trimmedInput[1][0])
{
    Console.WriteLine("Your initials start with the same letter");
}
else
{
    Console.WriteLine("Your initials do not start with the same letter");
}
// added comment