using Homework14;

Console.WriteLine("Your Bank");
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
            ErrorHandler.Error("Enter a valid change type");
            continue;
        }

        if (changeType == 0)
        {
            ErrorHandler.Warning("You are exiting this program...");
            return;
        }

        if (changeType == 3)
        {
            ShowBalance(account);
            continue;
        }
    
        Console.Write("Enter amount of money: ");
        string amount = Console.ReadLine()!;
        if (!decimal.TryParse(amount, out decimal changeAmount) || changeAmount <= 0)
        {
            ErrorHandler.Error("Enter a valid amount of money");
            continue;
        }
        
        account.ChangeBalance(changeAmount, (ChangeType)changeType);
        ShowBalance(account);
    }
}

void ShowBalance(Account accountToShow)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"{accountToShow.AccountName}'s balance: {accountToShow.Balance}");
    Console.ResetColor();
}

Account RegisterAccount()
{
    string name;
    decimal starterBalance;
    
    while (true)
    {
        Console.Write("\nEnter your account name: ");
        string nameInput = Console.ReadLine()!;
        if (nameInput == "")
        {
            ErrorHandler.Error("Enter a valid account name");
            continue;
        }
        name = nameInput;
        
        Console.Write("Enter your account start balance: ");
        string amountInput = Console.ReadLine()!;
        if (!decimal.TryParse(amountInput, out decimal amount) || amount <= 0)
        {
            ErrorHandler.Error("Enter a valid amount of money");
            continue;
        }
        
        starterBalance = amount;
        break;
    }
    
    Account sample = new(name, starterBalance);
    return sample;
}