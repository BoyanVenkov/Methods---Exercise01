int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());
int num3 = int.Parse(Console.ReadLine());

static int SmallestOfThreeNumbers(int a, int b, int c)
{
    int smallest = a;
    if (b < smallest)
    {
        smallest = b;
    }
    if (c < smallest)
    {
        smallest = c;
    }
    return smallest;
}
Console.WriteLine(SmallestOfThreeNumbers(num1, num2, num3));