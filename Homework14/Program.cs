using Homework14;

Console.WriteLine("1 - Withdraw money\n2 - Deposit money");
Account worker = new("Oleksiy", 2500);

SelectBalanceChange(worker);

void SelectBalanceChange(Account account)
{
    while (true)
    {
        Console.Write("\nEnter your balance change type: ");
        string change = Console.ReadLine()!;
        if (!int.TryParse(change, out int changeType) && changeType >= 0 && changeType <= 2)
        {
            continue;
        }

        if (changeType == 0)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("You are exiting the program...");
            return;
        }
    
        Console.Write("Enter amount of money: ");
        string amount = Console.ReadLine()!;
        if (!decimal.TryParse(amount, out decimal changeAmount) && changeAmount > 0)
        {
            continue;
        }
        account.ChangeBalance(changeAmount, (ChangeType)changeType);
    }
}