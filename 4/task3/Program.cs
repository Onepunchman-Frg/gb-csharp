string getLetters(string s)
{
    string letters = "";
    foreach (char e in s)
    {
        if (char.IsAsciiLetter(e))
        {
            letters += e;
        }
    }
    return letters;
}

Console.WriteLine("Password: ");
string? str = Console.ReadLine();
Console.WriteLine(getLetters(str));