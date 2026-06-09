
int[] firstArray = Console.ReadLine()
                          .Split(" ")
                          .Select(int.Parse)
                          .ToArray();

int[] secondArray = Console.ReadLine()
                          .Split(" ")
                          .Select(int.Parse)
                          .ToArray();

bool isIdentical = true;

for (int i = 0; i < firstArray.Length; i++)
{
    int firstArrayCurrentElement = firstArray[i];
    int secondArrayCurrentElement = secondArray[i];

    if (firstArrayCurrentElement != secondArrayCurrentElement)
    {
        isIdentical = false;
        break;
    }
}

if (isIdentical)
{
    Console.WriteLine("Arrays are identical.");
}
else
{
    Console.WriteLine("Arrays are not identical.");
}