string number = string.Empty;

PalindromeCheck(number);

static void PalindromeCheck(string num)
{
    string number = Console.ReadLine();
    while (number != "END")
    {
        
        string output = string.Empty;
        string compareNum = new string(number.Reverse().ToArray());
        if (number == compareNum)
        {
            output = "true";
        }
        else
        {
            output = "false";
        }

        Console.WriteLine(output);
        number = Console.ReadLine();
    }
}