namespace AccountManagement;

public class User
{
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
    
    public string UserName { get; }
    public int Id { get; }
}