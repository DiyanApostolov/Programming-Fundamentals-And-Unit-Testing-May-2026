
int number = int.Parse(Console.ReadLine());

int temp = number;
bool isSpecial = true;

while (temp > 0)
{
    int lastNumber = temp % 10;

    if (number % lastNumber != 0)
    {
        isSpecial = false;
        break;
    }

    temp = temp / 10;
}

if (isSpecial)
{
    Console.WriteLine($"{number} is special");
}
else
{
    Console.WriteLine($"{number} is not special");
}