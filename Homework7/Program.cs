string[] field = { "1", "2", "3", "4", "5", "6", "7", "8", "9"};

BuildField();

while (true)
{
    SetPlayerChoiceOnField("X", 1);
    bool isGameOver = CheckForWinnerAndDraw();
    if (isGameOver)
    {
        break;
    }
    
    SetPlayerChoiceOnField("O", 2);
    isGameOver = CheckForWinnerAndDraw();
    if (isGameOver)
    {
        break;
    }
}

//General methods
void SetPlayerChoiceOnField(string playerChoice, byte playerNumber)
{
    while (true)
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write($"\n{playerNumber}. player choice: ");
        string playerChoiceOnField = Console.ReadLine()!;
        Console.WriteLine();
        if (int.TryParse(playerChoiceOnField, out int number) && number > 0 && number < 10 && field[int.Parse(playerChoiceOnField) - 1] == playerChoiceOnField)
        {
            field[number - 1] = playerChoice;
            Console.ResetColor();
            BuildField();
            break;
        }
    }
}

void BuildField()
{
    for (int i = 0; i < field.Length; i++)
    {
        Console.Write($" {field[i]} |");
        if ((i + 1) % 3 == 0 && i != 8)
        {
            Console.WriteLine();
            Console.WriteLine("-------------");
        }
        else if (i == 8)
        {
            Console.WriteLine();
        }
    }
}

bool CheckForWinnerAndDraw()
{
    for (int i = 0; i < 3; i++)
    {
        bool firstPlayerWin = (field[3 * i] == "X" && field[3 * i + 1] == "X" && field[3 * i + 2] == "X") ||
                              (field[i] == "X" && field[i + 3] == "X" && field[i + 6] == "X") ||
                              (field[0] == "X" && field[4] == "X" && field[8] == "X") ||
                              (field[2] == "X" && field[4] == "X" && field[6] == "X");
        bool secondPlayerWin = (field[3 * i] == "O" && field[3 * i + 1] == "O" && field[3 * i + 2] == "O") ||
                               (field[i] == "O" && field[i + 3] == "O" && field[i + 6] == "O") ||
                               (field[0] == "O" && field[4] == "O" && field[8] == "O") ||
                               (field[2] == "O" && field[4] == "O" && field[6] == "O");
        if (firstPlayerWin)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nFirst player won!");
            return true;
        }
        if (secondPlayerWin)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nSecond player won!");
            return true;
        }
    }

    int fieldUnitsFilled = 0;

    foreach (string slot in field)
    {
        if (slot == "X" || slot == "O")
        {
            fieldUnitsFilled++;
        }
    }

    if (fieldUnitsFilled == 9)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("\nDraw!");
        return true;
    }

    return false;
}