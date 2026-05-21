
string season = Console.ReadLine();
string accommodationType = Console.ReadLine();
int countOfDays = int.Parse(Console.ReadLine());

// "Spring", "Summer", "Autumn" and "Winter"
// "Hotel" and "Camping"

double priceForOneDay = 0;
double discount = 0;

if (season == "Spring")
{
    discount = 0.2; // 20%

    if (accommodationType == "Hotel")
    {
        priceForOneDay = 30;
    }
    else if (accommodationType == "Camping")
    {
        priceForOneDay = 10;
    }
}
else if (season == "Summer")
{
    if (accommodationType == "Hotel")
    {
        priceForOneDay = 50;
    }
    else if (accommodationType == "Camping")
    {
        priceForOneDay = 30;
    }
}
else if (season == "Autumn")
{
    discount = 0.3; // 30%

    if (accommodationType == "Hotel")
    {
        priceForOneDay = 20;
    }
    else if (accommodationType == "Camping")
    {
        priceForOneDay = 15;
    }
}
else if (season == "Winter")
{
    discount = 0.1; // 10%

    if (accommodationType == "Hotel")
    {
        priceForOneDay = 40;
    }
    else if (accommodationType == "Camping")
    {
        priceForOneDay = 10;
    }
}

double finalPrice = countOfDays * priceForOneDay * (1 - discount);

Console.WriteLine($"{finalPrice:F2}");