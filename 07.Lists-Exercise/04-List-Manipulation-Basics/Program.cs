List<int> numbers = Console.ReadLine() //"4 19 2 53 6 43"
                           .Split(" ") //["4", "19", "2", "53", "6", "43"]
                           .Select(int.Parse) //[4, 19, 2, 53, 6, 43]
                           .ToList(); //{4, 19, 2, 53, 6, 43}

string command = Console.ReadLine();

while (command != "end")
{
    //обработвам командата -> command = "Insert 8 3"
  
    string[] commandParts = command.Split(" "); //["Insert", "8", "3"]
    string commandName = commandParts[0]; // "Insert"

    if (commandName == "Add")
    {
        //command = "Add 3".Split() -> commandParts = ["Add", "3"]
        //add a number to the end of the list
        int numberToAdd = int.Parse(commandParts[1]); // "3" -> int.Parse -> 3
        numbers.Add(numberToAdd);
    }
    else if (commandName == "Remove")
    {
        //command = "Remove 2".Split() -> commandParts = ["Remove", "2"]
        //remove a number from the list
        int numberToRemove = int.Parse(commandParts[1]); //"2" -> int.Parse -> 2
        numbers.Remove(numberToRemove);
    }
    else if (commandName == "RemoveAt")
    {
        //command = "RemoveAt 1".Split() -> commandParts = ["RemoveAt", "1"]
        //remove a number at a given index
        int indexToRemove = int.Parse(commandParts[1]); //"1" -> int.Parse -> 1
        numbers.RemoveAt(indexToRemove);
    }
    else if (commandName == "Insert")
    {
        //command = "Insert 8 3".Split() -> commandParts = ["Insert", "8", "3"]
        //insert a number at a given index
        int numberToInsert = int.Parse(commandParts[1]); //"8" -> int.Parse -> 8
        int indexToInsert = int.Parse(commandParts[2]); //"3" -> int.Parse -> 3
        numbers.Insert(indexToInsert, numberToInsert);
    }

    command = Console.ReadLine();
}

//отпечатваме елементите на списъка разделени с интервал
Console.WriteLine(string.Join(" ", numbers));



