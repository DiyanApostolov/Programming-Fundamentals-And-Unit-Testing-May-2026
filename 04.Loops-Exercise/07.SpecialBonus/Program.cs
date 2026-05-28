
int stopNumber = int.Parse(Console.ReadLine());
int previousNumber = 0;

while (true) // infinity loop
{
    int currentNumber = int.Parse(Console.ReadLine());
   
    if (stopNumber == currentNumber)
    {
        break;
    }

    previousNumber = currentNumber;
}

Console.WriteLine(previousNumber * 1.2); // +20%