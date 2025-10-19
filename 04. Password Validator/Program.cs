string password = Console.ReadLine();

PasswordValidator(password);


static void PasswordValidator(string input)
{
    int digitCount = input.Count(char.IsDigit);
    bool isValid = true;

    if (input.Length < 6 || input.Length > 10)
    {
        Console.WriteLine("Password must be between 6 and 10 characters");
        isValid = false;
    }
    if (input.Any(c => !char.IsLetterOrDigit(c)))
    {
        Console.WriteLine("Password must consist only of letters and digits");
        isValid = false;
    }
    if (digitCount < 2)
    {
        Console.WriteLine("Password must have at least 2 digits");
        isValid = false;
    }
    if (isValid == true)
    {
        Console.WriteLine("Password is valid");
    }

}