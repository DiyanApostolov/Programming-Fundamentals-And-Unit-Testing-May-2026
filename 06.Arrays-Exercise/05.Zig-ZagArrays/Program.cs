
int n = int.Parse(Console.ReadLine());

int[] firstOutputArray = new int[n];
int[] secondOutputArray = new int[n];

for (int i = 0; i < n; i++)
{
    int[] twoNumbers = Console.ReadLine()
                                .Split(" ")
                                .Select(int.Parse)
                                .ToArray();

    if (i % 2 == 0)
    {
        firstOutputArray[i] = twoNumbers[0];
        secondOutputArray[i] = twoNumbers[1];
    }
    else
    {
        // обратното
        firstOutputArray[i] = twoNumbers[1];
        secondOutputArray[i] = twoNumbers[0];
    }
}

Console.WriteLine(string.Join(" ", firstOutputArray));
Console.WriteLine(string.Join(" ", secondOutputArray));