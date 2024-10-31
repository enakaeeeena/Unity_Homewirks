using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите значение a: ");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите значение b: ");
        int b = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Пременная a = {a}, переменная b = {b}");

        a = a - b; 

        Console.WriteLine($"В результате переменная a = {a}, переменная b = {b}");
    }
}
