int FindVowesCount(string input)
{
    int vowelsCount = 0;

    for (int i = 0; i < input.Length; i++)
    {
        char letter = input[i];

        switch (letter)
        {
            case 'a' or 'o' or 'u' or 'i' or 'e':
            case 'A' or 'O' or 'U' or 'I' or 'E':
                vowelsCount++;
                break;
        }
    }

    return vowelsCount;
}


string text = Console.ReadLine();

int vowelsCount = FindVowesCount(text);

Console.WriteLine(vowelsCount);
