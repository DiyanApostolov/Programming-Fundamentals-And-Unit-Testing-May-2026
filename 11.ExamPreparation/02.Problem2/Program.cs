
int[] array = Console.ReadLine()
                    .Split(" ")
                    .Select(int.Parse)
                    .ToArray();

int rightMiddleIndex = array.Length / 2;
int leftMiddleIndex = rightMiddleIndex - 1;

int sumElements = array[leftMiddleIndex] + array[rightMiddleIndex];

double averageValue = (double)sumElements / 2;

Console.WriteLine($"{averageValue:F2}");