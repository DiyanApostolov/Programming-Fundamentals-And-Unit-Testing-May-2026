List<int> wagons = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

int maxCapacity = int.Parse(Console.ReadLine());

string command = Console.ReadLine();

while (command != "end")
{
    //обработваме командата -> "30"

    if (command.Contains("Add"))
    {
        //command = "Add 30".Split(" ") -> ["Add", "30"]
        //добавяме нов вагов в края на влака с определен брой пътници в него
        int passengersToAdd = int.Parse(command.Split(" ")[1]); //"30" -> parse -> 30
        wagons.Add(passengersToAdd);
    }
    else
    {
        //command = "30" -> влакът спира и се качват определен брой пътници
        int passengers = int.Parse(command); //"30" -> parse -> 30

        for (int position = 0; position <= wagons.Count - 1; position++)
        {
            int currentPassengers = wagons[position];
            if (currentPassengers + passengers <= maxCapacity)
            {
                //качвам хората в този вагон
                wagons[position] = currentPassengers + passengers;
                break; //прекратявам търсенето на вагон, в който да се съхранят
            }

        }
    }
    command = Console.ReadLine();
}

Console.WriteLine(string.Join(" ", wagons));

