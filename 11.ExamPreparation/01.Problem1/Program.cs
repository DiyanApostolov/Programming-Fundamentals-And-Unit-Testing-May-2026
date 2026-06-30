// string solution

string number = Console.ReadLine();

int sumfactorial = 0;

for (int i = 0; i < number.Length; i++)
{
    int currentdigit = int.Parse(number[i].ToString());

    if (currentdigit % 2 == 0)
    {
        int factorial = 1;

        for (int j = 1; j <= currentdigit; j++)
        {
            factorial *= j;
        }

        sumfactorial += factorial;
    }
}

Console.WriteLine(sumfactorial);

// int solution

int number = int.Parse(Console.ReadLine());

int sumFactorial = 0;

while (number > 0)
{
    int lastDigit = number % 10; // take last digit

    if (lastDigit % 2 == 0)
    {
        int factorial = 1;

        for (int j = 1; j <= lastDigit; j++)
        {
            factorial *= j;
        }

        sumFactorial += factorial;
    }

    number /= 10; // remove last gidit
}

Console.WriteLine(sumFactorial);
