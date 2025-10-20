int[] arrayIntegers = Console.ReadLine().Split().Select(int.Parse).ToArray();
string[] input = new string[3];

while (input[0] != "end")
{
    input = Console.ReadLine().Split().ToArray();
    if (input[0] == "end")
    {
        Console.WriteLine($"[{string.Join(", ", arrayIntegers)}]");
        return;
    }

    if (input[0] == "exchange")
    {
        if (int.Parse(input[1]) < 0 || int.Parse(input[1]) >= arrayIntegers.Length)
        {
            Console.WriteLine("Invalid index");
            continue;
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
            int maxEven = int.MinValue;
            int maxEvenIndex = -1;
            for (int i = 0; i < arrayIntegers.Length; i++)
            {
                if (arrayIntegers[i] % 2 == 0 && arrayIntegers[i] >= maxEven)
                {
                    maxEven = arrayIntegers[i];
                    maxEvenIndex = i;
                }
            }
            if (maxEvenIndex == -1)
            {
                Console.WriteLine("No matches");
                continue;
            }
            Console.WriteLine(maxEvenIndex);
        }
        if (input[1] == "odd")
        {
            int maxOdd = int.MinValue;
            int maxOddIndex = -1;
            for (int i = 0; i < arrayIntegers.Length; i++)
            {
                if (arrayIntegers[i] % 2 != 0 && arrayIntegers[i] >= maxOdd)
                {
                    maxOdd = arrayIntegers[i];
                    maxOddIndex = i;
                }
            }
            if (maxOddIndex == -1)
            {
                Console.WriteLine("No matches");
                continue;
            }
            Console.WriteLine(maxOddIndex);
        }
    }
    if (input[0] == "min")
    {
        if (input[1] == "even")
        {
            int minEven = int.MaxValue;
            int minEvenIndex = -1;
            for (int i = 0; i < arrayIntegers.Length; i++)
            {
                if (arrayIntegers[i] % 2 == 0 && arrayIntegers[i] <= minEven)
                {
                    minEven = arrayIntegers[i];
                    minEvenIndex = i;
                }
            }
            if (minEven == int.MaxValue)
            {
                Console.WriteLine("No matches");
                continue;
            }
            Console.WriteLine(minEvenIndex);
        }
        if (input[1] == "odd")
        {
            int minOdd = int.MaxValue;
            int minOddIndex = -1;
            for (int i = 0; i < arrayIntegers.Length; i++)
            {
                if (arrayIntegers[i] % 2 != 0 && arrayIntegers[i] <= minOdd)
                {
                    minOdd = arrayIntegers[i];
                    minOddIndex = i;
                }
            }
            if (minOdd == int.MaxValue)
            {
                Console.WriteLine("No matches");
                continue;
            }
            Console.WriteLine(minOddIndex);
        }
    }
    if (input[0] == "first")
    {
        int countToTake = int.Parse(input[1]);

        if (countToTake < 0 || countToTake > arrayIntegers.Length)
        {
            Console.WriteLine("Invalid count");
            continue;
        }

        if (input[2] == "even")
        {
            List<int> firstEvens = new List<int>();
            for (int i = 0; i < arrayIntegers.Length; i++)
            {
                if (arrayIntegers[i] % 2 == 0)
                {
                    firstEvens.Add(arrayIntegers[i]);
                    if (firstEvens.Count == countToTake)
                    {
                        break;
                    }
                }
            }
            Console.WriteLine($"[{string.Join(", ", firstEvens)}]");

        }
        if (input[2] == "odd")
        {
            List<int> firstOdds = new List<int>();
            for (int i = 0; i < arrayIntegers.Length; i++)
            {
                if (arrayIntegers[i] % 2 != 0)
                {
                    firstOdds.Add(arrayIntegers[i]);
                    if (firstOdds.Count == countToTake)
                    {
                        break;
                    }
                }
            }
            Console.WriteLine($"[{string.Join(", ", firstOdds)}]");
        }
    }
    if (input[0] == "last")
    {
        int countToTake = int.Parse(input[1]);
        if (countToTake < 0 || countToTake > arrayIntegers.Length)
        {
            Console.WriteLine("Invalid count");
            continue;
        }

        if (input[2] == "even")
        {
            List<int> lastEvens = new List<int>();
            for (int i = arrayIntegers.Length - 1; i >= 0; i--)
            {
                if (arrayIntegers[i] % 2 == 0)
                {
                    lastEvens.Add(arrayIntegers[i]);
                    if (lastEvens.Count == countToTake)
                    {
                        break;
                    }
                }
            }
            lastEvens.Reverse();
            Console.WriteLine($"[{string.Join(", ", lastEvens)}]");
        }
        if (input[2] == "odd")
        {
            List<int> lastOdds = new List<int>();
            for (int i = arrayIntegers.Length - 1; i >= 0; i--)
            {
                if (arrayIntegers[i] % 2 != 0)
                {
                    lastOdds.Add(arrayIntegers[i]);
                    if (lastOdds.Count == countToTake)
                    {
                        break;
                    }
                }
            }
            lastOdds.Reverse();
            Console.WriteLine($"[{string.Join(", ", lastOdds)}]");
        }
    }
}