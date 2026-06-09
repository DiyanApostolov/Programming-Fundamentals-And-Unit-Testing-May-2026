
int[] inputArray = Console.ReadLine()
                          .Split(" ")
                          .Select(int.Parse)
                          .ToArray();

while (inputArray.Length > 1)
{
    int[] condensedArray = new int[inputArray.Length - 1];

    for (int i = 0; i < inputArray.Length - 1; i++) // до предпоследния елемент!!!
    {
        int currentElement = inputArray[i];
        int nextRigthElement = inputArray[i + 1];

        condensedArray[i] = currentElement + nextRigthElement;
    }

    inputArray = condensedArray; // презаписвам кондензирания масив върху оригиналния (входния)
}

Console.WriteLine(inputArray[0]);