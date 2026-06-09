
int[] inputArray = Console.ReadLine()
                          .Split(" ")
                          .Select(int.Parse)
                          .ToArray();

int rotations = int.Parse(Console.ReadLine());

rotations = rotations % inputArray.Length; // оптимизираме решението с по-малко ротации

for (int i = 0; i < rotations; i++)
{
    int firstElement = inputArray[0]; // изваждам си първия елемент

    for (int j = 1; j < inputArray.Length; j++)  // премествам всички елемент с 1 индекс на ляво
    {
        inputArray[j - 1] = inputArray[j];
    }

    inputArray[inputArray.Length - 1] = firstElement; // замествам последният елемент с първия
}

Console.WriteLine(string.Join(" ", inputArray));