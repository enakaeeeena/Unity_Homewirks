using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите натуральное число: ");
        string input = Console.ReadLine();

     

        char[] digits = input.ToCharArray();

     
        Array.Sort(digits);

       
        if (digits[0] == '0')
        {
   
            for (int i = 1; i < digits.Length; i++)
            {
                if (digits[i] != '0')
                {
                
                    char temp = digits[0];
                    digits[0] = digits[i];
                    digits[i] = temp;
                    break;
                }
            }
        }
        string result = new string(digits);
        Console.WriteLine($"Наименьшее число, составленное из цифр: {result}");
    }
}