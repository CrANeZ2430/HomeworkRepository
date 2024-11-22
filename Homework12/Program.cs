while (true)
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.Write("Enter digit of the Fibonacci number: ");
    string input = Console.ReadLine()!;
    if (int.TryParse(input, out int fibonacciNumberOrder))
    {
        Console.ResetColor();
        Console.WriteLine("Your Fibonacci number: " + AdditionalMath.CalculateFibonacciNumber(fibonacciNumberOrder));
        break;
    }
}

public static class AdditionalMath
{
    private static long currentNumber;
    private static long nextNumber = 1;
    private const int ExceptedVars = 2;
    
    public static long CalculateFibonacciNumber(int number)
    {
        if (number < 0)
        {
            Console.WriteLine("The number cannot be negative");
            return -1;
        }
        if (number == 1)
        {
            return 0;
        }
        if (number == 2)
        {
            return 1;
        }

        long previousNumber = currentNumber;
        currentNumber = nextNumber;
        nextNumber = previousNumber + nextNumber;
        if (number - ExceptedVars != 0)
        {
            CalculateFibonacciNumber(number - 1);
        }
        return nextNumber;
    }
}