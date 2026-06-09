
int[] firstArray = Console.ReadLine()
                          .Split(" ")
                          .Select(int.Parse)
                          .ToArray();

int[] secondArray = Console.ReadLine()
                          .Split(" ")
                          .Select(int.Parse)
                          .ToArray();

string output = "";

foreach (int firstArrayElement in firstArray)
{
    foreach (int secondArrayElement in secondArray)
    {
        if (firstArrayElement == secondArrayElement)
        {
            output += $"{firstArrayElement} "; // concatenation
            break;
        }
    }
}

Console.WriteLine(output);
