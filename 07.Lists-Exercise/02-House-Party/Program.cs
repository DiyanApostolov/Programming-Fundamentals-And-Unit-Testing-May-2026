List<string> guestlist = new List<string>(); //празен лист, в който си съхраняваме имената на гостите на партито

int countCommands = int.Parse(Console.ReadLine());

for (int count = 1; count <= countCommands; count++)
{
    string command = Console.ReadLine();
    //command = "George is not going!".Split(" ") -> ["George", "is", "not", "going!"]

    string name = command.Split(" ")[0]; //"George"
   
    if (command.Contains(" is going!"))
    {
        //1. command = "{name} is going!"
        //има в списъка с гости
        if (guestlist.Contains(name))
        {
            Console.WriteLine($"{name} is already in the list!");
        }
        //няма в списъка с гости
        else
        {
            guestlist.Add(name);
        }
    }
    else if (command.Contains(" is not going!"))
    {
        //2. command = "{name} is not going!"

        //има в списъка с гости
        if (guestlist.Contains(name))
        {
            guestlist.Remove(name);
        }
        //няма в списъка с гости
        else
        {
            Console.WriteLine($"{name} is not in the list!");
        }
    }
}

//обработили всички команди
//guestlist = {"Allie"}
foreach (string name in guestlist)
{
    Console.WriteLine(name);
}

