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
        byte workerAm;
        decimal nWorkerSalary;
        decimal totalSalarySum = 0;
        
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("\nFirst point");
        Console.ResetColor();
        
        Console.Write("Enter amount of workers: ");
        while (!byte.TryParse(Console.ReadLine(), out workerAm) || workerAm <= 0)
        {
            Console.WriteLine("Invalid amount of workers");
            Console.Write("Enter amount of worker: ");
        }

        for (int i = 1; i <= workerAm; i++)
        {
            Console.Write($"Enter {i}. worker's salary: ");
            while (!decimal.TryParse(Console.ReadLine(), out nWorkerSalary) || nWorkerSalary <= 0)
            {
                Console.WriteLine("Invalid salary");
                Console.Write($"Enter {i}. worker's salary: ");
            }
            totalSalarySum += nWorkerSalary;
        }
        
        Console.WriteLine($"Average salary: {totalSalarySum / workerAm}");
    }

    private static void SecondPoint()
    {
        int userRowsNum;
        int userColumnsNum;
        
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("\nSecond point");
        Console.ResetColor();
        
        Console.Write("Enter amount of rows: ");
        while (!int.TryParse(Console.ReadLine(), out userRowsNum) || userRowsNum <= 0)
        {
            Console.WriteLine("Please enter a valid number");
            Console.Write("Enter number: ");
        }
        userColumnsNum = userRowsNum;

        Console.Write("Your graph is: ");
        Console.WriteLine();
        for (int rowsNum = 1; rowsNum <= userRowsNum; rowsNum++)
        {
            for (int columnsNum = 1; columnsNum <= userColumnsNum; columnsNum++)
            {
                if (columnsNum > userColumnsNum - rowsNum)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(" ");
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
        string password;
        
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("\nFourth point");
        Console.ResetColor();
        
        Console.WriteLine("Your password must contain at least 8 characters, at least 1 digit and ! @ #");
        Console.Write("Enter your password: ");
        password = Console.ReadLine()!;
        while ((!password.Contains("0") && !password.Contains("1") && !password.Contains("2") && 
               !password.Contains("3") && !password.Contains("4") && !password.Contains("5") && 
               !password.Contains("6") && !password.Contains("7") && !password.Contains("8") && 
               !password.Contains("9")) || !password.Contains("!") || !password.Contains("@") || 
               !password.Contains("#") || password.Length < 8)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Invalid password");
            Console.ResetColor();
            Console.Write("Enter your password: ");
            password = Console.ReadLine()!;
        }
        
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Your password is correct");
        Console.ResetColor();
    }

    private static void FifthPoint()
    {
        int userNum;
        long preLastNum;
        long lastNum;
        
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("\nFifth point");
        Console.ResetColor();
        
        Console.Write("Enter number: ");
        while (!int.TryParse(Console.ReadLine(), out userNum) || userNum <= 0)
        {
            Console.WriteLine("Please enter a valid number");
            Console.Write("Enter number: ");
        }
        
        Console.WriteLine("Your Fibonacci's sequence: ");
        Console.Write("0, 1");
            
        if (userNum != 1)
        {
            preLastNum = 0;
            lastNum = 1;
            for (int sequenceNum = 3; sequenceNum <= userNum; sequenceNum++)
            {
                long newNum = lastNum + preLastNum;
                Console.Write($", {newNum}");
                preLastNum = lastNum;
                lastNum = newNum;
            }
        }
    }

    private static void SixthPoint()
    {
        decimal workHoursAm;
        decimal salaryPerHour;
        
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("\nSixth point");
        Console.ResetColor();
        
        Console.Write("Enter amount of work hours: ");
        while (!decimal.TryParse(Console.ReadLine(), out workHoursAm) || workHoursAm <= 0 || workHoursAm > 16)
        {
            Console.WriteLine("Invalid amount of work hours");
            Console.Write("Enter amount of work hours: ");
        }
        
        Console.Write("Enter salary per hour: ");
        while (!decimal.TryParse(Console.ReadLine(), out salaryPerHour)  || workHoursAm <= 0)
        {
            Console.WriteLine("Invalid salary per hour");
            Console.Write("Enter salary per hour: ");
        }
        
        Console.WriteLine($"Your day salary: {workHoursAm * salaryPerHour}");
    }

    private static void SeventhPoint()
    {
        int userNum;

        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("\nSeventh point");
        Console.ResetColor();
        
        Console.Write("Enter number: ");
        while (!int.TryParse(Console.ReadLine(), out userNum) || userNum <= 0)
        {
            Console.WriteLine("Please enter a valid number");
            Console.Write("Enter number: ");
        }

        Console.WriteLine("Your multiplication table: ");
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{userNum}x{i} = {userNum * i}");
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