
double n1 = double.Parse(Console.ReadLine());
double n2 = double.Parse(Console.ReadLine());
double n3 = double.Parse(Console.ReadLine());

if (n1 == 0 || n2 == 0 || n3 == 0)
{
    Console.WriteLine("zero");
}
else if (n1 > 0 && n2 > 0 && n3 > 0)
{
    Console.WriteLine("positive");
}
else if (n1 < 0 && n2 < 0 && n3 < 0)
{
    Console.WriteLine("negative");
}
else if (n1 < 0) // -
{
    if (n2 < 0 && n3 > 0) // - * - * + = +
    {
        Console.WriteLine("positive");
    }
    else if (n2 > 0 && n3 < 0) // - * + * - = +
    {
        Console.WriteLine("positive");
    }
    else if (n2 > 0 && n3 > 0) // - * + * + = -
    {
        Console.WriteLine("negative");
    }
}
else if (n1 > 0)
{
    if (n2 < 0 && n3 > 0) // + * - * + = -
    {
        Console.WriteLine("negative");
    }
    else if (n2 > 0 && n3 < 0) // + * + * - = -
    {
        Console.WriteLine("negative");
    }
    else if (n2 < 0 && n3 < 0) // + * - * - = -
    {
        Console.WriteLine("negative");
    }
}
else if (n2 < 0)
{
    if (n1 < 0 && n3 > 0) // - * - * + = +
    {
        Console.WriteLine("positive");
    }
    else if (n1 > 0 && n3 > 0) // + * - * + = -
    {
        Console.WriteLine("negative");
    }
}
