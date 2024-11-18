int guessWordsAmount = Enum.GetValuesAsUnderlyingType<GuessWords>().Length;
const byte maxAttempts = 6;
byte currentAttempts = maxAttempts;
char guessLetter;
string guessedLetters = "";

Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("Try to guess encrypted word");
string encryptedWord = ((GuessWords)Random.Shared.Next(0, guessWordsAmount)).ToString().ToLower();
Console.WriteLine($"The amount of letters in a word: {encryptedWord.Length}");
Console.WriteLine($"The amount of attempts: {currentAttempts}\n");
Console.ResetColor();

while (guessedLetters.Length != encryptedWord.Length)
{
    while (true)
    {
        Console.Write("Your letter: ");
        if (char.TryParse(Console.ReadLine(), out guessLetter) && char.IsLetter(guessLetter))
        {
            break;
        }
    }
    
    CheckRightLetter();
    if (currentAttempts == 0)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"\nYou lost! The encrypted word: {encryptedWord}");
        return;
    }
}

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"\nYou won! The encrypted word: {encryptedWord}");

void CheckRightLetter()
{
    foreach (char letter in guessedLetters)
    {
        if (letter == guessLetter)
        {
            Console.Write("You have already guessed the letter!\n");
            return;
        }
    }
    
    if (encryptedWord.Contains(guessLetter))
    {
        Console.Write("The position of your letter: ");
        for (int i = 1; i <= encryptedWord.Length; i++)
        {
            if (encryptedWord[i - 1] == guessLetter)
            {
                Console.Write($"{i} ");
                guessedLetters += guessLetter;
            }
        }
        Console.WriteLine();
        return;
    }

    currentAttempts--;
    Console.WriteLine($"The word does not contain your letter. Your attempts: {currentAttempts}");
}

enum GuessWords
{
    Forest,
    Plant,
    Human,
    Water,
    Color,
    Scissors,
    Pencil,
    Paper,
    Bottle
}