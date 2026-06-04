
string product = Console.ReadLine();
int quantity = int.Parse(Console.ReadLine());

PrintCaculatedPrice(product, quantity);

static void PrintCaculatedPrice(string product, int quantity)
{
    // coffee – 1.50
    // water – 1.00
    // coke – 1.40
    // snacks – 2.00

    double price = 0;

    switch (product)
    {
        case "coffee": price = 1.50; break;
        case "water": price = 1.00; break;
        case "coke": price = 1.40; break;
        case "snacks": price = 2.00; break;
    }

    double finalPrice = price * quantity;

    Console.WriteLine($"{finalPrice:F2}");
}