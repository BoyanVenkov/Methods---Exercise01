char firstChar = char.Parse(Console.ReadLine());
char secondChar = char.Parse(Console.ReadLine());

CharOutput(firstChar, secondChar);

static void CharOutput(char a, char b)
{

    if (b < a)
    {
        char temp = a;
        a = b;
        b = temp;
        for (int i = a + 1; i < b; i++)
        {
            Console.Write($"{(char)(i)} ");
        }
        return;
    }
    for (int i = a + 1; i < b; i++)
    {
        Console.Write($"{(char)(i)} ");
    }

}


