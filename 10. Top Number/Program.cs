int endValue = int.Parse(Console.ReadLine());

TopNumber(endValue);


static void TopNumber(int num)
{
    for (int i = 17; i <= num; i++)
    {
        int sum = 0;
        int numI = i;
        int oddNum = 0;
        int lastNum = 0;
        while (numI > 0)
        {
            lastNum += numI % 10;
            sum += numI % 10;
            if (lastNum % 2 != 0)
            {
                oddNum += numI;
            }
            numI /= 10;

        }
        if (sum % 8 == 0 && oddNum > 0)
        {
            Console.WriteLine(i);
        
        }

    }


}