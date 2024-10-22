public class Calculator
{
    private static decimal firstNum;
    private static decimal secondNum;
    private static string arOperation;

    private static void Main()
    {
        int i = 1;

        while (true)
        {
            Console.WriteLine($"Calculation number {i}");

            Console.Write("Enter first number: ");
            while (!decimal.TryParse(Console.ReadLine(), out firstNum))
            {
                Console.WriteLine("Incorrect first number input");
                Console.Write("Enter first number: ");
                continue;
            }

            Console.Write("Enter second number: ");
            while (!decimal.TryParse(Console.ReadLine(), out secondNum))
            {
                Console.WriteLine("Incorrect second number input");
                Console.Write("Enter second number: ");
                continue;
            }


            while (CheckArithmeticOperations())
            {
                Console.Write("Enter arithmetic operation: ");
                arOperation = Console.ReadLine();
                if (CheckArithmeticOperations())
                {
                    Console.WriteLine("Incorect arithmetic operation input");
                    continue; ;
                }
            }

            decimal resultNum = GetResultOfTwoNumbers(firstNum, secondNum, arOperation);
            Console.WriteLine(resultNum);
            arOperation = "";
            i++;

            Console.WriteLine();
        }
    }

    private static decimal GetResultOfTwoNumbers(decimal number1, decimal number2, string operation)
    {
        switch (operation)
        {
            case "+":
                return number1 + number2;
            case "-":
                return number1 - number2;
            case "*":
                return number1 * number2;
            case "/":
                return number1 / number2;
            default:
                return 0;
        }
    }

    private static bool CheckArithmeticOperations()
    {
        if (arOperation != "+" && arOperation != "-" && arOperation != "*" && arOperation != "/")
        {
            return true;
        }

        return false;
    }
}