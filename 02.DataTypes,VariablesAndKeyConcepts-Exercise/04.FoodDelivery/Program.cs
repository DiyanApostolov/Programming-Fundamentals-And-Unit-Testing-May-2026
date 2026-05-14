// Input
int numberOfChickenMenus = int.Parse(Console.ReadLine());
int numberOfFishMenus = int.Parse(Console.ReadLine());
int numberOfVegetarianMenus = int.Parse(Console.ReadLine());

// Calculations
double chickenMenuPrice = 10.35;
double fishMenuPrice = 12.40;
double vegetarianMenuPrice = 8.15;
double deliveryPrice = 2.50;

double priceForChickenMenus = numberOfChickenMenus * chickenMenuPrice;
double priceForFishMenus = numberOfFishMenus * fishMenuPrice;
double priceForVegetarianMenus =  numberOfVegetarianMenus * vegetarianMenuPrice;

double totalBill = priceForChickenMenus + priceForFishMenus + priceForVegetarianMenus;
double dessertPrice = totalBill * 0.2;

double finalPrice = totalBill + dessertPrice + deliveryPrice;

// Output
Console.WriteLine(finalPrice);