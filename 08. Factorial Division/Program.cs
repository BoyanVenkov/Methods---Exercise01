using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        int num1 = int.Parse(Console.ReadLine());
        int num2 = int.Parse(Console.ReadLine());

        BigInteger factorial1 = Factorial(num1);
        BigInteger factorial2 = Factorial(num2);

        decimal result = (decimal)factorial1 / (decimal)factorial2;
        Console.WriteLine($"{result:F2}");
    }

    static BigInteger Factorial(int n)
    {
        BigInteger fact = 1;
        for (int i = 1; i <= n; i++)
        {
            fact *= i;
        }
        return fact;
    }
}