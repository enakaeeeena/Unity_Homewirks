using System;

//Реализовать класс, представляющий из себя комплексное число.
//Он должен поддерживать основные операции
//(сложение, умножение, деление, возведение в степень, извлечение корня),
//плюс нахождение модуля и вычисление угла. 


class ComplexNumber
{
    private double realPart; 
    private double imaginaryPart; 

    // Конструктор
    public ComplexNumber(double real, double imaginary)
    {
        realPart = real;
        imaginaryPart = imaginary;
    }

    // Метод сложения
    public ComplexNumber Add(ComplexNumber other)
    {
        return new ComplexNumber(realPart + other.realPart, imaginaryPart + other.imaginaryPart);
    }

    // Метод умножения
    public ComplexNumber Multiply(ComplexNumber other)
    {
        double real = (realPart * other.realPart) - (imaginaryPart * other.imaginaryPart);
    double imaginary = (realPart * other.imaginaryPart) + (imaginaryPart * other.realPart);
        return new ComplexNumber(real, imaginary);
     }


    // Метод деления
    public ComplexNumber Del(ComplexNumber other)
    {
        double denominator = (other.realPart * other.realPart) + (other.imaginaryPart * other.imaginaryPart);
        double real = ((realPart * other.realPart) + (imaginaryPart * other.imaginaryPart)) / denominator;
        double imaginary = ((imaginaryPart * other.realPart) - (realPart * other.imaginaryPart)) / denominator;
        return new ComplexNumber(real, imaginary);
    }

    // Метод возведения в степень
    public ComplexNumber Step(int exponent)
    {
        ComplexNumber result = new ComplexNumber(1, 0); // Начальное значение 1 + 0i
        for (int i = 0; i < exponent; i++)
        {
            result = result.Multiply(this);
        }
        return result;
    } 

    // Метод извлечения корня
    public ComplexNumber Square()
    {
        double modulus = Modul();
        double angle = Angle();
        double sqrtModulus = Math.Sqrt(modulus);
        double halfAngle = angle / 2;

    double real = sqrtModulus * Math.Cos(halfAngle);
    double imaginary = sqrtModulus * Math.Sin(halfAngle);
    return new ComplexNumber(real, imaginary);
}

    // Метод нахождения модуля
    public double Modul()
    {
        return Math.Sqrt((realPart * realPart) + (imaginaryPart * imaginaryPart));
    }

    // Метод вычисления угла
    public double Angle()
    {
        return Math.Atan2(imaginaryPart, realPart);
    }

    // Метод для вывода комплексного числа
    public override string ToString()
    {
        return $"{realPart} + {imaginaryPart}i";
    }
}

class Program
{
    static void Main(string[] args)
    {
        ComplexNumber complex1 = new ComplexNumber(7, 3);
        ComplexNumber complex2 = new ComplexNumber(1, 4);

        Console.WriteLine($"Комплексное число 1: {complex1}");
        Console.WriteLine($"Комплексное число 2: {complex2}");

        ComplexNumber sum = complex1.Add(complex2);
        Console.WriteLine($"Сумма: {sum}");

        ComplexNumber product = complex1.Multiply(complex2);
        Console.WriteLine($"Произведение: {product}");

        ComplexNumber quotient = complex1.Del(complex2);
        Console.WriteLine($"Частное: {quotient}");

        ComplexNumber power = complex1.Step(2);
        Console.WriteLine($"Возведение в степень 2: {power}");

        ComplexNumber sqrt = complex1.Square();
        Console.WriteLine($"Квадратный корень: {sqrt}");

        double modulus = complex1.Modul();
        Console.WriteLine($"Модуль: {modulus}");

        double angle = complex1.Angle();
        Console.WriteLine($"Угол: {angle}");
    }
}




