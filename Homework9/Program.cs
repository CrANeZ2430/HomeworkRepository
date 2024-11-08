byte homeworkNumber;

while (true)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Enter the number of homework: ");
    if (byte.TryParse(Console.ReadLine(), out homeworkNumber) && homeworkNumber <= 4)
    {
        Console.ResetColor();
        break;
    }
}

switch (homeworkNumber)
{
    case 1:
        FirstHomework();
        break;
    case 2:
        SecondHomework();
        break;
    case 3:
        ThirdHomework();
        break;
    case 4:
        FourthHomework();
        break;
}

void FirstHomework()
{
    
}

void SecondHomework()
{
    
}

void ThirdHomework()
{
    
}

void FourthHomework()
{
    
}