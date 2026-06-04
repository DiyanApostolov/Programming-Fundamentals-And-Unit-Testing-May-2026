
int firstNumber = int.Parse(Console.ReadLine());
int secondNumber = int.Parse(Console.ReadLine());

int result = FindFactorial(firstNumber) / FindFactorial(secondNumber);

Console.WriteLine(result);

int FindFactorial(int number)
{
    int result = 1;

    for (int i = 2; i <= number; i++)
    {
        result *= i;
    }

    return result;
}