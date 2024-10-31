// Написать программу, которая считает факториалы чисел до заданного числа.

using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите натуральное число: ");

        
        if (!int.TryParse(Console.ReadLine(), out int n) || n < 0) // Преобразовывет строку в число и проверяет что оно натуральное
        {
            Console.WriteLine("Ошибка: Введите корректное натуральное число.");
            return;
        }

        Console.WriteLine($"Факториалы чисел от 0 до {n}:");

        for (int i = 0; i <= n; i++)
        {
            Console.WriteLine($"{i}! = {Factorial(i)}");
        }
    }

    
    static long Factorial(int number)
    {
        if (number == 0 || number == 1)
            return 1;

        long result = 1;
        for (int i = 2; i <= number; i++)
        {
            result *= i;
        }
        return result;
    }
}
