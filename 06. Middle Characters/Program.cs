string input = Console.ReadLine();

FindTheMiddleChar(input);

static void FindTheMiddleChar(string word)
{
    char middleChar = ' ';
    char middleCharTwo = ' ';
    string middleString = " ";
    if (word.Length % 2 != 0)
    {
        middleChar = word[word.Length / 2];
        middleString = ($"{middleChar}");
    }
    else
    {
        middleCharTwo = word[(word.Length / 2) - 1];
        middleChar = word[word.Length / 2];
        middleString = ($"{middleCharTwo}{middleChar}");
    }

    Console.WriteLine(middleString);
}



