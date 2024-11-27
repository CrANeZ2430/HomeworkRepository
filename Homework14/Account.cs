namespace Homework14;

public class Account
{
    private string AccountName { get; }
    private int AccountId { get; }
    private decimal Balance {get; set;}

    public Account(string accountName, decimal balance)
    {
        AccountName = accountName;
        AccountId = Random.Shared.Next(1000, 10000);
        Balance = balance;
    }

    public void ChangeBalance(decimal amount, ChangeType changeType)
    {
        switch (changeType)
        {
            case ChangeType.Withdraw:
                Balance += amount;
                break;
            case ChangeType.Deposit:
                Balance += amount;
                break;
        }
        
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"{AccountName} {changeType.ToString()}s money");
        Console.WriteLine($"{AccountName} current balance: {Balance}");
        Console.ResetColor();
    }
}