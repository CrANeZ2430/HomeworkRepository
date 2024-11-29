namespace Homework14;

public class Account
{
    public Account(string accountName, decimal balance)
    {
        AccountName = accountName;
        Balance = balance;
    }
    
    private decimal _balance;
    
    public Account(string accountName, decimal balance)
    {
        AccountName = accountName;
        Balance = balance;
    }
    
    public string AccountName { get; }
    public decimal Balance
    {
        get { return _balance; }
        private set
        {
            if (value < 0)
            {
                ErrorHandler.Error("You don't have enough money");
                return;
            }

            _balance = value;
        }
    }

    public void ChangeBalance(decimal amount, ChangeType changeType)
    {
        switch (changeType)
        {
            case ChangeType.Withdraw:
                Balance -= amount;
                break;
            case ChangeType.Deposit:
                Balance += amount;
                break;
        }
    }
}