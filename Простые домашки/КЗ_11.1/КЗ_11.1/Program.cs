using System;
using System.IO; // для работы с файлами

class Program
{
    static void Main(string[] args)
    {
  
        string fileName = "f.txt"; // файл находится в папке bin\Debug\net8.0

        // Создание файла
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            // Заголовок
            writer.WriteLine("x\tsin(x)");

            // Задаем шаг
            for (double x = 0; x <= 1; x += 0.1)
            {
                double sinValue = Math.Sin(x);

                // Записываем значения в файл
                writer.WriteLine($"{x:F1}\t{sinValue:F5}");
            }
        }

        Console.WriteLine($"Таблица значений sin(x) записана в файл {fileName}");
    }
}

