int number = int.Parse(Console.ReadLine());

NxNMethodPrint(number);


static void NxNMethodPrint(int num)
{
    for (int i = 1; i <= num; i++)
    {
        for (int j = 1; j <= num; j++)
        {
            if (j == num)
            {
                Console.WriteLine($"{num}");
                break;
            }
            Console.Write($"{num} ");
        }
    }

}