List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

string infoBomb = Console.ReadLine();
//infoBomb = "4 2".Split(" ") -> ["4", "2"]

int value = int.Parse(infoBomb.Split(" ")[0]); //4 -> стойността на бомбата
int power = int.Parse(infoBomb.Split(" ")[1]); //2 -> сила на бомбата


//докато има бомба аз я гърмя
while (numbers.Contains(value))
{
    //намираме къде е бомбата
    int bombIndex = numbers.IndexOf(value); //позиция на бомбата

    int startIndex = bombIndex - power; //от къде започваме да унищожаваме
    int endIndex = bombIndex + power; //до къде приключваме да унищожаваме

    //ако излезем извън рамките на списъка
    if (startIndex < 0)
    {
        startIndex = 0;
    }

    if (endIndex > numbers.Count - 1)
    {
        endIndex = numbers.Count - 1;
    }

    //унищожаваме == поставяне на 0 вместо числата
    for (int index = startIndex; index <= endIndex; index++)
    {
        numbers[index] = 0;
    }
}


//след унищожаването
Console.WriteLine(numbers.Sum());