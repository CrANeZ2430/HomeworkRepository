namespace Homework14;

public class Account
{
    private string AccountName { get; }
    private decimal Balance {get; set;}

    public Account(string accountName, decimal balance)
    {
        AccountName = accountName;
        Balance = balance;
    }

    public void ChangeBalance(decimal amount, ChangeType changeType)
    {
        switch (changeType)
        {
            case ChangeType.Withdraw:
                if (Balance < amount)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You don't have enough money");
                    Console.ResetColor();
                    return;
                }
                Balance -= amount;
                break;
            case ChangeType.Deposit:
                Balance += amount;
                break;
        }
        
        ShowBalance();
    }

    public void ShowBalance()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"{AccountName} current balance: {Balance}");
        Console.ResetColor();
    }
}