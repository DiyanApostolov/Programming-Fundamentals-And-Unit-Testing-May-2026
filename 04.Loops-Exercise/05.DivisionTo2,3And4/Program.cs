
int n = int.Parse(Console.ReadLine());

int divediBy2Counter = 0;
int divediBy3Counter = 0;
int divediBy4Counter = 0;

for (int i = 0; i < n; i++)
{
    int currentNumber = int.Parse(Console.ReadLine());

    if (currentNumber % 2 == 0)
        divediBy2Counter++;
   
    if (currentNumber % 3 == 0)
        divediBy3Counter++;

    if(currentNumber % 4 == 0)
        divediBy4Counter++;
}

double percentDivideBy2 = (double)divediBy2Counter / n * 100;
double percentDivideBy3 = (double)divediBy3Counter / n * 100;
double percentDivideBy4 = (double)divediBy4Counter / n * 100;

Console.WriteLine($"{percentDivideBy2:F2}%");
Console.WriteLine($"{percentDivideBy3:F2}%");
Console.WriteLine($"{percentDivideBy4:F2}%");
