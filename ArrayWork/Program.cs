byte homeworkNumber;
int[] sampleArray = {};

while (true)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write("Enter the number of task (enter 0 to finish): ");
    if (byte.TryParse(Console.ReadLine(), out homeworkNumber) && homeworkNumber <= 2)
    {
        Console.ResetColor();
        break;
    }
}

switch (homeworkNumber)
{
    case 1:
        CheckIsArraySorted(sampleArray);
        break;
    case 2:
        GetAverageArrayValue(sampleArray);
        break;
}

void CheckIsArraySorted(int[] array)
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("\nFirst task");
    Console.ResetColor();

    int checkNumber = 0;

    if (array.Length == 0)
    {
        Console.Write("Array consists of 0 elements");
        return;
    }
    if (array.Length == 1)
    {
        Console.Write("Array consists of 1 element");
        return;
    }
    
    for (int i = 0; i < array.Length; i++)
    {
        if (i != 0 && array[i - 1] < array[i])
        {
            checkNumber += 2;
        }
        if (i != 0 && array[i - 1] > array[i])
        {
            checkNumber += 1;
            break;
        }
        if (i != 0 && array[i - 1] == array[i])
        {
            checkNumber += 0;
        }
    }

    if (checkNumber == 0)
    {
        Console.WriteLine("Array is static");
        return;
    }

    switch (checkNumber % 2)
    {
        case 0:
            Console.WriteLine("Array is sorted");
            break;
        case 1:
            Console.WriteLine("Array is not sorted");
            break;
    }
}

void GetAverageArrayValue(int[] array)
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("\nSecond task");
    Console.ResetColor();
    
    if (array.Length == 0)
    {
        Console.WriteLine("The average value of an array: 0");
        return;
    }
    if (array.Length == 1)
    {
        Console.WriteLine($"The average value of an array: {array[0]}");
        return;
    }

    decimal totalSum = 0;
    
    foreach (int item in array)
    {
        totalSum += item;
    }
    
    Console.WriteLine($"The average value of an array: {totalSum / array.Length}");
}