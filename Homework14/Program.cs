using Homework14;

Account client = RegisterAccount();

Console.WriteLine("\n\t1 - Withdraw money\n\t2 - Deposit money\n\t3 - Show money");
SelectBalanceChange(client);

void SelectBalanceChange(Account account)
{
    while (true)
    {
        Console.Write("\nEnter your balance manipulation type: ");
        string change = Console.ReadLine()!;
        if (!int.TryParse(change, out int changeType) && changeType < 0 || changeType > 4)
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

Account RegisterAccount()
{
    string name = "";
    decimal starterBalance;
    
    while (true)
    {
        Console.Write("Enter your account name: ");
        string nameInput = Console.ReadLine()!;
        if (nameInput == "")
        {
            continue;
        }
        name = nameInput;
        
        Console.Write("Enter your account start balance: ");
        string amountInput = Console.ReadLine()!;
        if (!decimal.TryParse(amountInput, out decimal amount) || amount <= 0)
        {
            continue;
        }
        
        starterBalance = amount;
        break;
    }
    
    Account sample = new(name, starterBalance);
    return sample;
}