
int[] inputArray = Console.ReadLine()
                          .Split(" ")
                          .Select(int.Parse)
                          .ToArray();

string output = "";

for (int i = 0; i < inputArray.Length; i++)
{
    bool isTopInteger = true;
    int currentElement = inputArray[i];

    for (int j = i+1; j < inputArray.Length; j++)
    {
        int nextRigthElement = inputArray[j];

        if (currentElement <= nextRigthElement)
        {
            isTopInteger = false;
            break;
        }
    }

    if (isTopInteger)
    {
        output += $"{currentElement} ";
    }
}

Console.WriteLine(output);
