byte homeworkNumber;

while (true)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write("Enter number of homework: ");
    if (byte.TryParse(Console.ReadLine(), out homeworkNumber) && homeworkNumber >= 1 && homeworkNumber <= 5)
    {
        break;
    }
}
Console.ResetColor();

switch (homeworkNumber)
{
    case 1:
        FirstAndSecondHomework();
        break;
    case 2:
        FirstAndSecondHomework();
        break;
    case 3:
        ThirdHomework();
        break;
    case 4:
        FourthHomework();
        break;
    case 5:
        FifthHomework();
        break;
}

void FirstAndSecondHomework()
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("\n1-2 homework");
    Console.ResetColor();
    
    int[] array = new int[10];
    int arraySum = 0;
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(-10, 11);
    }

    Console.WriteLine("Array members with even index:");
    Console.Write(array[0]);
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 == 0)
        {
            Console.Write($", {array[i]}");
        }
    }
    Console.WriteLine();

    foreach (int i in array)
    {
        arraySum += i;
    }
    if (arraySum % 2 == 0)
    {
        Console.WriteLine("Array sum is even");
    }
    else if (arraySum % 2 != 0)
    {
        Console.WriteLine("Array sum is odd");
    }
}

void ThirdHomework()
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("\n3 homework");
    Console.ResetColor();
    
    int[,] matrix = new int[9,9];
    
    Console.WriteLine("Your multiplication table:");
    for (int i = 1; i <= 9; i++)
    {
        for (int j = 1; j <= 9; j++)
        {
            matrix[i - 1, j - 1] = i * j;
            Console.Write($"{matrix[i - 1, j - 1]} ");
            if (j == 9)
            {
                Console.WriteLine();
            }
        }
    }
}

void FourthHomework()
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("\n4 homework");
    Console.ResetColor();
    
    int[,] matrix = new int[5,5];
    int [] biggestNumberCoordinates = new int[2];
    int [] smallestNumberCoordinates = new int[2];
    int biggestMatrixNumber = 0;
    int smallestMatrixNumber = 0;
    Random random = new Random();
    for (int i = 0; i < 5; i++)
    {
        for (int j = 0; j < 5; j++)
        {
            matrix[i, j] = random.Next(-10, 11);
        }
    }

    for (int i = 0; i < 5; i++)
    {
        for (int j = 0; j < 5; j++)
        {
            if (matrix[i, j] > biggestMatrixNumber)
            {
                biggestMatrixNumber = matrix[i, j];
                biggestNumberCoordinates[0] = i;
                biggestNumberCoordinates[1] = j;
            }
            else if (matrix[i, j] < smallestMatrixNumber)
            {
                smallestMatrixNumber = matrix[i, j];
                smallestNumberCoordinates[0] = i;
                smallestNumberCoordinates[1] = j;
            }
        }
    }
    
    Console.WriteLine($"Biggest number in matrix is {biggestMatrixNumber} " +
                      $"on coordinates {biggestNumberCoordinates[0]}, {biggestNumberCoordinates[1]}");
    Console.WriteLine($"Biggest number in matrix is {smallestMatrixNumber} " +
                      $"on coordinates {smallestNumberCoordinates[0]}, {smallestNumberCoordinates[1]}");
}

void FifthHomework()
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("\n5 homework");
    Console.ResetColor();

    int daysInterval;
    
    while (true)
    {
        Console.Write("Enter number of days: ");
        if (int.TryParse(Console.ReadLine(), out daysInterval) && daysInterval >= 0)
        {
            break;
        }
    }
    
    int dayNumber = daysInterval % 7;
    if (daysInterval == 1)
    {
        Console.WriteLine($"Today is Monday and in 1 day will be {(DayOfWeek)dayNumber}.");
    }
    else
    {
        Console.WriteLine($"Today is Monday and in {daysInterval} days will be {(DayOfWeek)dayNumber}.");
    }
}

enum DayOfWeek
{
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday,
    Sunday
}