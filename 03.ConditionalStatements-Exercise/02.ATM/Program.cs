
int balance = int.Parse(Console.ReadLine()); 
int withdraw = int.Parse(Console.ReadLine()); 
int limit = int.Parse(Console.ReadLine());

// Solution with simple boolean operators
if (withdraw > limit)
{
    Console.WriteLine("The limit was exceeded.");
}
else if (withdraw > balance)
{
    Console.WriteLine("Insufficient availability.");
}
else
{
    Console.WriteLine("The withdraw was successful.");
}

// Solution with && operator
if (withdraw <= limit && balance >= withdraw)
{
    Console.WriteLine("The withdraw was successful.");
}
else if (withdraw > limit)
{
    Console.WriteLine("The limit was exceeded.");
}
else
{
    Console.WriteLine("Insufficient availability.");
}