namespace AccountManagement;

public class User
{
    private string _username;
    
    public User(string userName)
    {
        UserName = userName;
        Id = Random.Shared.Next(1000, 10000);
    }

    public User(string userName, int id)
    {
        UserName = userName;
        Id = id;
    }

    public string UserName
    {
        get
        {
            return _username;
        }

        set
        {
            if (value == null && value.Any(char.IsDigit))
            {
                MessageHandler.Error("User name cannot be null");
                return;
            }
            
            _username = value;
        }
    }
    public int Id { get; }
}