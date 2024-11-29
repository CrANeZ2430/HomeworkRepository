using AccountManagement;

Console.WriteLine("\t1 - Upload accounts\n\t2 - Download accounts\n\t3 - Show all accounts" +
                  "\n\t4 - Login\n\t5 - Register\n\t6 - Show my account");

User myAccount = null;
List<User> users = new List<User>();

while (true)
{
    SelectAction();
}
void SelectAction()
{
    int actionNumber;
    
    while (true)
    {
        Console.Write("\nEnter action number: ");
        string input = Console.ReadLine()!;
        if (int.TryParse(input, out actionNumber) && actionNumber > 0 && actionNumber < 7)
        {
            break;
        }
    }

    switch (actionNumber)
    {
        case 1:
            StorageManagement.SaveUserAccounts(users);
            break;
        case 2:
            StorageManagement.GetUserAccounts(users);
            break;
        case 3:
            ShowAllAccounts();
            break;
        case 4:
            LoginAccount();
            break;
        case 5:
            RegisterAccount();
            break;
        case 6:
            ShowMyAccounts();
            break;
    }
}

void LoginAccount()
{
    string userName;
    int userId;

    while (true)
    {
        Console.Write("Enter user name: ");
        string input = Console.ReadLine()!;
        if (input != "" && !input.Any(char.IsDigit))
        {
            userName = input;
            break;
        }
        MessageHandler.Error("Please enter a valid username");
    }
    
    while (true)
    {
        Console.Write("Enter user Id: ");
        string input = Console.ReadLine()!;
        if (int.TryParse(input, out userId) && input.Length > 0 && input.Length < 5)
        {
            break;
        }
        MessageHandler.Error("Please enter a valid Id");
    }

    if (users.Any(u => u.UserName == userName && u.Id == userId))
    {
        myAccount = users.First(u => u.UserName == userName && u.Id == userId);
    }
    
    myAccount = new User(userName, userId);
    MessageHandler.Message("You are logged in!");
}

void RegisterAccount()
{
    string userName;
    
    while (true)
    {
        Console.Write("Enter your account name: ");
        string nameInput = Console.ReadLine()!;
        if (nameInput != "" && !nameInput.Any(char.IsDigit))
        {
            userName = nameInput;
            break;
        }
        MessageHandler.Error("Enter a valid account name\n");
    }
    
    User sampleUser = new(userName);
    MessageHandler.Message("\nAccount was successfully registered");
    Console.WriteLine($"\t{sampleUser.UserName} - {sampleUser.Id}");
    users.Add(sampleUser);
}

void ShowAllAccounts()
{
    if (users.Count == 0)
    {
        MessageHandler.Error("You don't have any accounts");
        return;
    }

    foreach (var user in users)
    {
        Console.WriteLine($"\n\t{user.UserName} - {user.Id}");
    }
}

void ShowMyAccounts()
{
    if (myAccount == null)
    {
        MessageHandler.Error("You are not logged in");
        return;
    }
    Console.WriteLine($"\t{myAccount.UserName} - {myAccount.Id}");
}