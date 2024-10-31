//Написать программу, печатающую все простые числа, не превосходящие заданного числа;


using System;

class PrimeNumberFinder
{
    static void Main(string[] args)
    {
        Console.Write("Введите верхний предел: ");

  
        if (int.TryParse(Console.ReadLine(), out int upperLimit) && upperLimit > 1)
        {
            Console.WriteLine($"Простые числа до {upperLimit}:");
            for (int num = 2; num <= upperLimit; num++)
            {
                if (IsNumberPrime(num))
                {
                    Console.WriteLine(num);
                }
            }
        }
        else
        {
            Console.WriteLine("Ошибка: пожалуйста, введите целое число больше 1.");
        }
    }

   
    static bool IsNumberPrime(int candidate)
    {
        if (candidate< 2) return false;
        
  
        for (int divisor = 2; divisor <= Math.Sqrt(candidate); divisor++)
        {
            if (candidate % divisor == 0)
            {
                return false; 
            }
        }
return true; 
    }
}


