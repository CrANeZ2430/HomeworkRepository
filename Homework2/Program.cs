public class DayOfWeekNaming
{
    private static byte weekDayNum;

    private static void Main()
    {
        while (true)
        {
            Console.Write("Enter the day of week (1-7): ");

            if (!byte.TryParse(Console.ReadLine(), out weekDayNum) || 1 > weekDayNum || weekDayNum > 7)
            {
                Console.WriteLine("Incorect day of week input");
                Console.WriteLine();
                continue;
            }

            string weekDayText = GetDayOfWeekByNum(weekDayNum);
            Console.WriteLine(weekDayText);
            Console.WriteLine();
        }
    }

    private static string GetDayOfWeekByNum(byte number)
    {
        switch (number)
        {
            case 1:
                return "Monday";
            case 2:
                return "Tuesday";
            case 3:
                return "Wednesday";
            case 4:
                return "Thursday";
            case 5:
                return "Friday";
            case 6:
                return "Saturday";
            case 7:
                return "Sunday";
            default:
                return "Incorrect day of week";
        }
    }
}


