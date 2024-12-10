using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите число n:");
        int n = int.Parse(Console.ReadLine());

        int steps = CountSteps(n);
        Console.WriteLine($"Количество замен, необходимых для достижения 1: {steps}");
    }

    static int CountSteps(int n)
    {
        int count = 0;

        while (n != 1)
        {
            if (n % 2 == 0) 
            {
                n /= 2;
            }
            else 
            {
                n = 3 * n + 1;
            }
            count++;
        }

        return count;
    }
}

