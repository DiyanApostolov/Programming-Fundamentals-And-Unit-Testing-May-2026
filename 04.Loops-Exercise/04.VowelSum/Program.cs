
int n = int.Parse(Console.ReadLine());

int points = 0;

for (int i = 0; i < n; i++)
{
    char currentSymbol = char.Parse(Console.ReadLine());

    switch (currentSymbol)
    {
        case 'a': points++; break;
        case 'e': points += 2; break;
        case 'i': points += 3; break;
        case 'o': points += 4; break;
        case 'u': points += 5; break;
    }
}

Console.WriteLine(points);