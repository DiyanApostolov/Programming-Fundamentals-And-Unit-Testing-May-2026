
// Input
int amountOfNylon = int.Parse(Console.ReadLine());
int amountOfPaint = int.Parse(Console.ReadLine());
int amountOfThinner = int.Parse(Console.ReadLine());
int hoursForCratfsmen = int.Parse(Console.ReadLine());

// Calculations
double nylonPrice = 1.50;
double paintPrice = 14.50;
double thinnerPrice = 5;
double bagsPrice = 0.40;

double priceForNylon = (amountOfNylon + 2) * nylonPrice;
double priceForPaint = amountOfPaint * 1.1 * paintPrice; // * 1.1 => +10%
double pricForThinner = amountOfThinner * thinnerPrice;

double priceForAllMaterials = priceForNylon + priceForPaint + pricForThinner + bagsPrice;

double priceForOneHourWork = priceForAllMaterials * 0.3;
double priceForCraftsmen = hoursForCratfsmen * priceForOneHourWork;

double finalSum = priceForAllMaterials + priceForCraftsmen;

// Output

Console.WriteLine(finalSum);