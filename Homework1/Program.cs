public class OrderForming
{

    private static byte orderNum = 1;
    private static decimal productPrice = 0;
    private static string productName;

    private static void Main()
    {
        Console.Write("Enter your amount of orders: ");
        byte orderAm = byte.Parse(Console.ReadLine());

        Console.WriteLine();

        for (byte i = 0; i < orderAm; i++)
        {
            Console.Write("Enter your name: ");
            string clientName = Console.ReadLine();

            while (productName != "smartphone" && productName != "laptop" && productName != "keyboard")
            {
                Console.Write("Enter product(smartphone/laptop/keyboard): ");
                productName = Console.ReadLine().ToLower();
            }

            ProductPriceOut(productName);

            Console.Write("Enter your street name: ");
            string streetName = Console.ReadLine();

            Console.Write("Enter your house number: ");
            byte houseNum = byte.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine($"Order No {orderNum}");
            Console.WriteLine($"Client: {clientName}.");
            Console.WriteLine($"Product: {productName}, price: {productPrice} EUR.");
            Console.WriteLine($"Adress: {streetName} Street, {houseNum}.");

            productName = null;

            orderNum++;

            Console.ReadLine();
        }

    }

    private static void ProductPriceOut(string productName)
    {
        switch (productName)
        {
            case ("smartphone"):
                productPrice = 305.99m;
                break;
            case ("laptop"):
                productPrice = 570.99m;
                break;
            case ("keyboard"):
                productPrice = 5.50m;
                break;
        }
    }
}