
string input = Console.ReadLine();

double accountBalance = 0;

while (input != "End")
{
    double money = double.Parse(input);

    if (money > 0)
    {
        accountBalance += money;
        Console.WriteLine($"Increase: {money:F2}");
    }
    else
    {
        accountBalance -= Math.Abs(money);
        Console.WriteLine($"Decrease: {Math.Abs(money):F2}");
    }

    input = Console.ReadLine();
}

Console.WriteLine($"Balance: {accountBalance:F2}");
