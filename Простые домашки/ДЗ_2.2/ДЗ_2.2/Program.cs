// Напечатать наибольшее и следующее по величине число из 10 введенных. Предполагается, что все введенные числа различны.

using System;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = new int[10];

     
        Console.WriteLine("Введите 10 различных чисел:");

        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Число {i + 1}: ");
            numbers[i] = Convert.ToInt32(Console.ReadLine());
        }

        
        int max = int.MinValue;
        int secondMax = int.MinValue;

      
        foreach (int number in numbers)
        {
            if (number > max)
            {
                secondMax = max; 
                max = number;     
            }
            else if (number > secondMax && number < max)
            {
                secondMax = number; 
            }
        }

        Console.WriteLine($"Наибольшее число: {max}");
        Console.WriteLine($"Следующее по величине число: {secondMax}");
    }
}
