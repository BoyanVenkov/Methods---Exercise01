int firstNum = int.Parse(Console.ReadLine());
int secondNum = int.Parse(Console.ReadLine());
int thirdNum = int.Parse(Console.ReadLine());

int firstOperation = IntegerCalculations(firstNum, secondNum);


static int IntegerCalculations(int num1, int num2)
{
    int sum = num1 + num2;

    return sum;

}

static int IntegerFinalResult(int num1, int num2)
{
    int totalSum = 0;
    totalSum = num1 - num2;

    return totalSum;
}

Console.WriteLine(IntegerFinalResult(firstOperation, thirdNum));