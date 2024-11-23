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
    
    public static long CalculateFibonacciNumber(int orderNumber)
    {
        if (orderNumber < 0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("The number cannot be negative or zero");
            Console.ResetColor();
            return -1;
        }
        if (orderNumber == 1)
        {
            return 0;
        }
        if (orderNumber == 2)
        {
            return 1;
        }

        long previousNumber = currentNumber;
        currentNumber = nextNumber;
        nextNumber = previousNumber + nextNumber;
        if (orderNumber - ExceptedVars != 0)
        {
            CalculateFibonacciNumber(orderNumber - 1);
        }
        return nextNumber;
    }
}