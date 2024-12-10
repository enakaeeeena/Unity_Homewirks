using System;

namespace NumberValidator
{
    public class NumberException : Exception
    {
        public NumberException(string message) : base(message) { }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите число в диапазоне от -2,147,483,648 до 2,147,483,647:");

            try
            {
                int number = GetValidatedNumber(Console.ReadLine());
                Console.WriteLine($"Вы ввели корректное число");
            }
            catch (NumberException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
        }

        public static int GetValidatedNumber(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                throw new NumberException("Введено не число.");
            }

            if (!int.TryParse(input, out int number))
            {
                throw new NumberException("Введено не число.");
            }

            if (number < -2147483648)
            {
                throw new NumberException("Введено слишком маленькое число.");
            }

            if (number > 2147483647)
            {
                throw new NumberException("Введено слишком большое число.");
            }

            return number;
        }
    }
}

