using System;

namespace _04._Password_validator
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            bool isHaveEnoughLength = length(password);
            bool isHaveEnoughDigits = digits(password);
            bool isHaveOnlyCharsAndDigits = isHaveDigitsAndCharacters(password);

            if (isHaveEnoughLength&&isHaveOnlyCharsAndDigits&&isHaveEnoughDigits)
            {
                Console.WriteLine("Password is valid");
            }
            if (!isHaveEnoughLength)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            if (!isHaveOnlyCharsAndDigits)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            if (!isHaveEnoughDigits)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }
        }
        static bool length(string password)
        {
            bool isEnoughLength = false;
            
            if (password.Length>=6&&password.Length<=10)
            {
                isEnoughLength = true;
            }
            return isEnoughLength;
        }
        static bool digits(string password)
        {
            bool isEnoughDigits = false;
            int counter = 0;
            for (int i = 0; i < password.Length; i++)
            {
                if (char.IsDigit(password[i]))
                {
                    counter++;
                }
            }
            if (counter>=2)
            {
                isEnoughDigits = true;
            }
            return isEnoughDigits;
        }
        static bool isHaveDigitsAndCharacters(string password)
        {
            bool isHaveDigitsAndCharacters = true;

            for (int i = 0; i < password.Length; i++)
            {
                if (!char.IsLetterOrDigit(password[i]))
                {
                    isHaveDigitsAndCharacters = false;
                }
            }
            return isHaveDigitsAndCharacters;
        }
    }
}
