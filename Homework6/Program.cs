public class LoopUtilization
{
    private static void Main()
    {
        byte pointInHomework;
        
        Console.Write("Enter point of homework: ");
        while (!byte.TryParse(Console.ReadLine(), out pointInHomework) || pointInHomework > 8 || pointInHomework == 0)
        {
            Console.WriteLine("Invalid point of homework number");
            Console.Write("Enter point of homework: ");
        }

        switch (pointInHomework)
        {
            case 1:
                FirstPoint();
                break;
            case 2:
                SecondPoint();
                break;
            case 3:
                ThirdPoint();
                break;
            case 4:
                FourthPoint();
                break;
            case 5:
                FifthPoint();
                break;
            case 6:
                SixthPoint();
                break;
            case 7:
                SeventhPoint();
                break;
            case 8:
                EighthPoint();
                break;
        }
    }

    private static void FirstPoint()
    {
        //implementation
    }

    private static void SecondPoint()
    {
        int userRowsAm;
        int userColumnsAm;
        
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("\nSecond point");
        Console.ResetColor();
        
        Console.Write("Enter amount of rows: ");
        while (!int.TryParse(Console.ReadLine(), out userRowsAm) || userRowsAm <= 0)
        {
            Console.WriteLine("Please enter a valid number");
            Console.Write("Enter number: ");
        }
        userColumnsAm = userRowsAm;

        Console.Write("Your graph is: ");
        for (int i = 1; i <= userRowsAm; i++)
        {
            for (int j = 1; j <= userColumnsAm; j++)
            {
                if (j >= userColumnsAm + 1 - i)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(".");
                }
            }
            Console.WriteLine();
        }
    }
    
    private static void ThirdPoint()
    {
        int userNum;
        int withoutRemCount = 0;

        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("\nThird point");
        Console.ResetColor();
        
        Console.Write("Enter number: ");
        while (!int.TryParse(Console.ReadLine(), out userNum) || userNum < 1)
        {
            Console.WriteLine("Please enter a valid number. Enter integer number bigger than 0");
            Console.Write("Enter number: ");
        }
        
        Console.WriteLine("Your prime numbers:");
        Console.Write("1");
        if (userNum == 1)
        {
            return;
        }
        //Check every number from 2 till userNumber
        for (int iterationNum = 2; iterationNum <= userNum; iterationNum++)
        {
            //Check every number from division on numbers from 2 till this number
            for (int divCheckNum = 2; divCheckNum <= iterationNum; divCheckNum++)
            {
                if (iterationNum % divCheckNum == 0)
                {
                    withoutRemCount++;
                }
            }
            
            if (withoutRemCount == 1)
            {
                Console.Write($", {iterationNum}");
            }
            
            withoutRemCount = 0;
        }
    }

    private static void FourthPoint()
    {
        //implementation
    }

    private static void FifthPoint()
    {
        int userNumb;
        int preLastNum;
        int lastNum;
        
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("\nFifth point");
        Console.ResetColor();
        
        Console.Write("Enter number: ");
        while (!int.TryParse(Console.ReadLine(), out userNumb) || userNumb <= 0)
        {
            Console.WriteLine("Please enter a valid number");
            Console.Write("Enter number: ");
        }
        
        Console.WriteLine("Your Fibonacci's sequence: ");
        Console.Write("0, 1");
            
        if (userNumb != 1)
        {
            preLastNum = 0;
            lastNum = 1;
            for (int sequenceNum = 3; sequenceNum <= userNumb; sequenceNum++)
            {
                int newNum = lastNum + preLastNum;
                Console.Write($", {newNum}");
                preLastNum = lastNum;
                lastNum = newNum;
            }
        }
    }

    private static void SixthPoint()
    {
        //implementation
    }

    private static void SeventhPoint()
    {
        int userNumb;

        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("\nSeventh point");
        Console.ResetColor();
        
        Console.Write("Enter number: ");
        while (!int.TryParse(Console.ReadLine(), out userNumb) || userNumb <= 0)
        {
            Console.WriteLine("Please enter a valid number");
            Console.Write("Enter number: ");
        }

        Console.WriteLine("Your multiplication table: ");
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{userNumb}x{i} = {userNumb * i}");
        }
    }

    private static void EighthPoint()
    {
        int userNum;
        int withoutRemCount = 0;
        bool isPrimeNum = false;

        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("\nEighth point");
        Console.ResetColor();
        
        Console.Write("Enter number: ");
        while (!int.TryParse(Console.ReadLine(), out userNum) || userNum <= 0)
        {
            Console.WriteLine("Please enter a valid number. Enter integer number bigger than 0");
            Console.Write("Enter number: ");
        }

        if (userNum == 1)
        {
            Console.WriteLine("Your number is prime");
            return;
        }
        
        for (int divCheckNum = 2; divCheckNum <= userNum; divCheckNum++)
        {
            if (userNum % divCheckNum == 0)
            {
                withoutRemCount++;
            }
        }

        if (withoutRemCount == 1)
        {
            isPrimeNum = true;
        }

        if (isPrimeNum)
        {
            Console.WriteLine("Your number is prime");
        }
        else
        {
            Console.WriteLine("Your number is not prime");
        }
    }
}