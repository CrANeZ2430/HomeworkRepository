public class CheckForInvalidNumberException
{
    private static byte userAge;

    private static void Main()
    {
        while (true)
        {
            Console.Write("Enter user age: ");

            try
            {
                userAge = byte.Parse(Console.ReadLine()!);
                break;
            }
            catch
            {
                Console.WriteLine("Invalid age numder. Reenter user age\n");
            }
        }

        Console.WriteLine($"User's age is {userAge}");
    }
}