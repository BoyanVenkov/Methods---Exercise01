int[] arrayIntegers = Console.ReadLine().Split().Select(int.Parse).ToArray();
string[] input = Console.ReadLine().Split().ToArray();

while (input[0] != "end")
{

    if (input[0] == "exchange")
    {
        if (int.Parse(input[1]) < 0 || int.Parse(input[1]) >= arrayIntegers.Length)
        {
            Console.WriteLine("Invalid index");
            break;
        }
        int count = 0;
        int index = 0;
        int[] subArray = arrayIntegers.ToArray();
        for (int i = int.Parse(input[1]) + 1; i < arrayIntegers.Length; i++)
        {
            subArray[index] = arrayIntegers[i];
            index++;
        }
        for (int i = index; i < arrayIntegers.Length; i++)
        {

            subArray[i] = arrayIntegers[count];
            count++;
        }
        arrayIntegers = subArray.ToArray();
    }
    if (input[0] == "max")
    {
        if (input[1] == "even")
        {
            int maxEven = 0;
            int maxEvenIndex = 0;
            for (int i = 0; i < arrayIntegers.Length; i++)
            {
                if (arrayIntegers[i] % 2 == 0 && arrayIntegers[i] >= maxEven)
                { 
                    maxEven = arrayIntegers[i];
                    maxEvenIndex = i;
                }
            }
            if (maxEvenIndex == 0)
            {
                Console.WriteLine("No matches");
                break;
            }
            Console.WriteLine(maxEvenIndex);
        }
        if (input[1] == "odd")
        {
            int maxOdd = 0;
            int maxOddIndex = 0;
            for (int i = 0; i < arrayIntegers.Length; i++)
            {
                if (arrayIntegers[i] % 2 != 0 && arrayIntegers[i] >= maxOdd)
                {
                    maxOdd = arrayIntegers[i];
                    maxOddIndex = i;
                }
            }
            if (maxOddIndex == 0)
            {
                Console.WriteLine("No matches");
                break;
            }
            Console.WriteLine(maxOddIndex);
        }
    }
    if (input[0] == "min")
    {

    }
    if (input[0] == "first")
    {
        if (input[2] == "even")
        {

        }
        if (input[2] == "odd")
        {

        }
    }
    if (input[0] == "last")
    {
        if (input[2] == "even")
        {

        }
        if (input[2] == "odd")
        {

        }
    }




    input = Console.ReadLine().Split().ToArray();
}