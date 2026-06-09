
int[] inputArray = Console.ReadLine()
                          .Split(" ")
                          .Select(int.Parse)
                          .ToArray();

int controlNumber = int.Parse(Console.ReadLine());

for (int i = 0; i < inputArray.Length - 1; i++) // до предпоследния елемент
{
    int currentElement = inputArray[i];

    for (int j = i + 1; j < inputArray.Length; j++) // започваме от следващия елемент от дясно
    {
        int nextRigthElement = inputArray[j];

        if (currentElement + nextRigthElement == controlNumber)
        {
            Console.WriteLine($"{currentElement} {nextRigthElement}");
        }
    }
}
