public class CheckForNullException
{
    private static decimal firstNum;
    private static decimal secondNum;
    private static decimal resultNum;

    private static void Main()
    {
        while (true)
        {
            Console.WriteLine("Dividing Calculator");

            Console.Write("\nEnter your first number: ");
            while (!decimal.TryParse(Console.ReadLine(), out firstNum))
            {
                Console.WriteLine("Enter valid number");
                Console.Write("Enter your first number: ");
                continue;
            }
            Console.Write("Enter your second number: ");
            while (!decimal.TryParse(Console.ReadLine(), out secondNum))
            {
                Console.WriteLine("Enter valid number");
                Console.Write("Enter your second number: ");
                continue;
            }

            Console.Write("\nThe result is: ");
            try
            {
                resultNum = firstNum / secondNum;
                Console.WriteLine(resultNum);
                break;
            }
            catch
            {
                Console.WriteLine("You cannot divide by zero. Reenter your digits\n");
            }
        }
    }
}