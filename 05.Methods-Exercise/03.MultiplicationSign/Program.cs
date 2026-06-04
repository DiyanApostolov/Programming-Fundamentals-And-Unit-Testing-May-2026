namespace _03.MultiplicationSign
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            int result = FindSignOfProduct(num1, num2, num3);

            if (result == 0)
            {
                Console.WriteLine("zero");
            }
            else if (result == 1)
            {
                Console.WriteLine("positive");
            }
            else if (result == -1) 
            {
                Console.WriteLine("negative");
            }

        }
        static int FindSignOfProduct(int n1, int n2, int n3)
        {
            if (n1 == 0 || n2 == 0 || n3 == 0)
            {
                return 0;
            }
            else if (n1 > 0 && n2 > 0 && n3 > 0)
            {
                return 1;
            }
            else if (n1 < 0 && n2 < 0 && n3 < 0)
            {
                return -1;
            }
            else if (n1 < 0) // -
            {
                if (n2 < 0 && n3 > 0) // - * - * + = +
                {
                    return 1;
                }
                else if (n2 > 0 && n3 < 0) // - * + * - = +
                {
                    return 1;
                }
                else if (n2 > 0 && n3 > 0) // - * + * + = -
                {
                    return -1;
                }
            }
            else if (n1 > 0)
            {
                if ((n2 < 0 && n3 > 0) || (n2 > 0 && n3 < 0) || (n2 < 0 && n3 < 0))
                {
                    return -1;
                }
            }
            else if (n2 < 0)
            {
                if (n1 < 0 && n3 > 0) // - * - * + = +
                {
                    return 1;
                }
                else if (n1 > 0 && n3 > 0) // + * - * + = -
                {
                    return -1;
                }
            }
            
            return 0;  
        }

    }
}
