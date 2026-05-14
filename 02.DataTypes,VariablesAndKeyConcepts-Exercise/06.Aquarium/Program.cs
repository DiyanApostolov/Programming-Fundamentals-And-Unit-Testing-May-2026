
int length  = int.Parse(Console.ReadLine());
int width = int.Parse(Console.ReadLine());
int height  = int.Parse(Console.ReadLine());
double percentOccupiedCpacity = double.Parse(Console.ReadLine());

int fishtankVolume = length * width * height;
double fishtankVolumeInLiters = (double)fishtankVolume / 1000; // int / int

double neededLiters = fishtankVolumeInLiters * (1 - (percentOccupiedCpacity / 100));

Console.WriteLine($"{neededLiters:F2}");
