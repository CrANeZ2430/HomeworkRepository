int fibonacciNumberOrder;

while (true)
{
    Console.Write("Enter Fibonacci number: ");
    string input = Console.ReadLine()!;
    if (int.TryParse(input, out fibonacciNumberOrder) && fibonacciNumberOrder > 0)
    {
        AdditionalMath.CalculateFibonacciNumber(fibonacciNumberOrder);
        break;
    }
}

static class AdditionalMath
{
    private static ulong temp1 = 0;
    private static ulong temp2 = 1;
    
    public static void CalculateFibonacciNumber(int number)
    {
        if (number == 1)
        {
            Console.WriteLine("Fibonacci number: 0");
            return;
        }
        if (number == 2)
        {
            Console.WriteLine("Fibonacci number: 1");
        }
        
        if (number - 3 == 0)
        {
            Console.WriteLine($"Fibonacci number: {temp1 + temp2}");
            return;
        }

        ulong temp01 = temp1;
        ulong temp02 = temp2;
        temp1 = temp02;
        temp2 = temp01 + temp02;
        CalculateFibonacciNumber(number - 1);
    }
}