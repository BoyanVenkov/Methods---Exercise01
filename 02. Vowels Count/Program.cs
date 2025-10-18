class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        VowelCount(input);
    }

    static void VowelCount(string text)
    {
        int count = 0;

        for (int i = 0; i < text.Length; i++)
        {
            if ("aeiouAEIOU".Contains(text[i]))
            {
                count++;
            }
        }

        Console.WriteLine(count);
    }
}