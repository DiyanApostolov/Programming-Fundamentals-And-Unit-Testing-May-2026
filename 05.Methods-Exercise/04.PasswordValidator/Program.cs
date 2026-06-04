namespace _04.PasswordValidator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            if (CheckPasswordLengthBetweenSixAndTenCharacters(password) &&
                CheckPasswordContainsOnlyLettersAndDigits(password) &&
                CheckPasswordContainsAtleastTwoDigits(password))
            {
                Console.WriteLine("Password is valid");
            }

            if (!CheckPasswordLengthBetweenSixAndTenCharacters(password))
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }

            if (!CheckPasswordContainsOnlyLettersAndDigits(password))
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }

            if (!CheckPasswordContainsAtleastTwoDigits(password))
            {
                Console.WriteLine("Password must have at least 2 digits");
            }
        }

        static bool CheckPasswordLengthBetweenSixAndTenCharacters(string password)
        {
            if (password.Length >= 6 && password.Length <= 10)
            {
                return true;
            }

            return false;
        }

        static bool CheckPasswordContainsOnlyLettersAndDigits(string password)
        {
            for (int i = 0; i < password.Length; i++)
            {
                char currentSymbol = password[i];
                if (!char.IsLetterOrDigit(currentSymbol))
                {
                    return false;
                }
            }

            return true;
        }

        static bool CheckPasswordContainsAtleastTwoDigits(string password)
        {
            int digits = 0;

            foreach (char currentSymbol in password)
            {
                if (char.IsDigit(currentSymbol))
                {
                    digits++;
                }
            }

            if (digits >= 2)
            {
                return true;
            }

            return false;
        }
    }
}
