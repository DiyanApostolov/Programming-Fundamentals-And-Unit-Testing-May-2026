List<int> numbers = Console.ReadLine()
                           .Split(" ")
                           .Select(int.Parse)
                           .ToList();

string command = Console.ReadLine();

while (command != "End")
{
    string[] commandParts = command.Split(" ");
    string commandName = commandParts[0];

    //command = "Shift left 2"
    //command = "Shift right 3"

    if (commandName == "Add")
    {
        //command = "Add 3".Split() -> commandParts = ["Add", "3"]
        //add a number to the end of the list
        int numberToAdd = int.Parse(commandParts[1]); // "3" -> int.Parse -> 3
        numbers.Add(numberToAdd);
    }
    else if (commandName == "Remove")
    {
        //command = "Remove 4".Split() -> commandParts = ["Remove", "4"]
        //remove the number at the given index
        int indexToRemove = int.Parse(commandParts[1]);
        if (indexToRemove >= 0 && indexToRemove <= numbers.Count - 1)
        {
            //валидна позиция
            numbers.RemoveAt(indexToRemove);
        }
        else
        {
            //невалидна позиция
            Console.WriteLine("Invalid index");
        }
    }
    else if (commandName == "Insert")
    {
        //command = "Insert 5 2".Split() -> commandParts = ["Insert", "5", "2"]
        int numberToInsert = int.Parse(commandParts[1]);
        int indexToInsert = int.Parse(commandParts[2]);

        if (indexToInsert >= 0 && indexToInsert <= numbers.Count - 1)
        {
            //валидна позиция
            numbers.Insert(indexToInsert, numberToInsert);
        }
        else
        {
            //невалидна позиция
            Console.WriteLine("Invalid index");
        }
    }
    else if (commandName == "Shift")
    {
        //shift == преместване
        //command = "Shift left 2".Split() -> commandParts = ["Shift", "left", "2"]
        //command = "Shift right 3".Split() -> commandParts = ["Shift", "right", "3"]
        string direction = commandParts[1]; //"left" или "right"
        int count = int.Parse(commandParts[2]);

        if (direction == "left")
        {
            //преместване ляво -> първото число да стане последно
            for (int i = 1; i <= count; i++)
            {
                int firstNumber = numbers[0];
                numbers.Add(firstNumber);
                numbers.RemoveAt(0);
            }
        }
        else if (direction == "right")
        {
            //преместване дясно -> последното число да стане първо
            for (int i = 1; i <= count; i++)
            {
                int lastNumber = numbers[numbers.Count - 1];
                numbers.Insert(0, lastNumber);
                numbers.RemoveAt(numbers.Count - 1);
            }

        }
    }

    command = Console.ReadLine();
}

Console.WriteLine(string.Join(" ", numbers));
