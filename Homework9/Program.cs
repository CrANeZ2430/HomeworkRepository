byte homeworkNumber;

while (true)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write("Enter the number of homework: ");
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
    int[] array = new int[10];
    int arrayLargestNumber = 0;
    int arraySecondLargestNumber = 0;
    Random random = Random.Shared;
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(100);
    }
    
    Console.WriteLine("\nYour array:");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > arrayLargestNumber)
        {
            arrayLargestNumber = array[i];
        }
    }
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > arraySecondLargestNumber && array[i] < arrayLargestNumber)
        {
            arraySecondLargestNumber = array[i];
        }
    }
    Console.WriteLine($"\nThe second largest number in the array: {arraySecondLargestNumber}");
}

void SecondHomework()
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("\nSecond homework");
    Console.ResetColor();
    
    int[,] matrix = new int[2,3];
    Random random = Random.Shared;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = random.Next(100);
        }
    }
    
    Console.WriteLine("\nYour matrix:");
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
            if (j == matrix.GetLength(1) - 1)
            {
                Console.WriteLine();
            }
        }
    }
    
    for (int k = 0; k < matrix.GetLength(0); k++)
    {
        for (int i = 0; i < matrix.GetLength(1); i++)
        {
            for (int j = 0; j < matrix.GetLength(1) - 1; j++)
            {
                if (matrix[k,j] > matrix[k,j + 1])
                {
                    int temp = matrix[k,j]; 
                    matrix[k,j] = matrix[k,j + 1];
                    matrix[k,j + 1] = temp;
                }
            }
        }
    }
    
    Console.WriteLine("\nYour sorted matrix:");
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
            if (j == matrix.GetLength(1) - 1)
            {
                Console.WriteLine();
            }
        }
    }
}

void ThirdHomework()
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("\nThird homework");
    Console.ResetColor();
    
    int[] array = new int[10];
    byte arrayItemIndex;
    Random random = Random.Shared;
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(100);
    }

    Console.WriteLine("\nYour array:");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
    
    while (true)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Enter the index of an array item: ");
        if (byte.TryParse(Console.ReadLine(), out arrayItemIndex) && arrayItemIndex < array.Length)
        {
            Console.ResetColor();
            break;
        }
    }

    for (int i = arrayItemIndex; i < array.Length - 1; i++)
    {
        array[i] = array[i + 1];
    }
    array[array.Length - 1] = 0;

    Console.WriteLine("\nYour reworked array:");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

void FourthHomework()
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("\nFourth homework");
    Console.ResetColor();
    
    int[,] matrix = new int [4,4];
    int sum = 0;
    Random random = Random.Shared;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = random.Next(100);
        }
    }
    
    Console.WriteLine("\nYour matrix:");
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
            if (j == matrix.GetLength(1) - 1)
            {
                Console.WriteLine();
            }
            
            if (i == j || i + j == matrix.GetLength(0) - 1)
            {
                sum += matrix[i, j];
            }
        }
    }
    
    Console.WriteLine($"\nThe sum of diagonal elements: {sum}");
}