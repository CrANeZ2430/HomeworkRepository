using AccountManagement;

Console.WriteLine("\t1 - Upload accounts\n\t2 - Download accounts\n\t3 - Login\n\t4 - Register\n");

List<User> users = new List<User>();
users.Add(new User("Micheal"));
users.Add(new User("Eduardo"));
users.Add(new User("Walter"));

User account = RegisterAccount();
users.Add(account);

SelectAction();
void SelectAction()
{
    int actionNumber;
    
    while (true)
    {
        Console.Write("\nEnter action number: ");
        string input = Console.ReadLine()!;
        if (int.TryParse(input, out actionNumber) && actionNumber > 0 && actionNumber < 5)
        {
            break;
        }
    }

    switch (actionNumber)
    {
        case 1:
            StorageManagement.CreateDirectory(users);
            break;
        case 2:
            break;
        case 3:
            break;
        case 4:
            break;
    }
}

User RegisterAccount()
{
    string name;
    
    while (true)
    {
        Console.Write("Enter your account name: ");
        string nameInput = Console.ReadLine()!;
        if (nameInput != "" && !nameInput.Any(char.IsDigit))
        {
            name = nameInput;
            break;
        }
        MessageHandler.Error("Enter a valid account name\n");
    }
    
    User sample = new(name);
    MessageHandler.Message("\nAccount was successfully registered");
    Console.WriteLine(sample.UserName);
    Console.WriteLine(sample.Id);
    return sample;
}