using Homework14;

Console.WriteLine("\t1 - Withdraw money\n\t2 - Deposit money\n\t3 - Show money\n\t4 - Register an account\n\t5 - Login");
Account worker = new("Oleksiy", 2500);

SelectBalanceChange(worker);

void SelectBalanceChange(Account account)
{
    while (true)
    {
        Console.Write("\nEnter your balance manipulation type: ");
        string change = Console.ReadLine()!;
        if (!int.TryParse(change, out int changeType) && changeType < 0 || changeType > 3)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Enter a valid change type");
            Console.ResetColor();
            continue;
        }

        if (changeType == 0)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("You are exiting the program...");
            return;
        }

        if (changeType == 3)
        {
            account.ShowBalance();
            continue;
        }
    
        Console.Write("Enter amount of money: ");
        string amount = Console.ReadLine()!;
        if (!decimal.TryParse(amount, out decimal changeAmount) || changeAmount <= 0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Enter valid amount of money");
            Console.ResetColor();
            continue;
        }
        account.ChangeBalance(changeAmount, (ChangeType)changeType);
    }
}