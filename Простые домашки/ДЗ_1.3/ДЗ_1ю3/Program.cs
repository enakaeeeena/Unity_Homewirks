//Рассмотрим решение квадратного уравнения. Мы будем обозначать его коэффициенты буквами a, b и c,
//причем предполагается, что a не равен 0. В конце мы должны получить число решений (нет, 1 или 2),
//и сами решения (если они есть). Усовершенствуйте вышеприведенный алгоритм так, чтобы он мог выдавать
//правильные результаты для любого уравнения степени не выше двух, т. е. и в тех случаях, когда старшие коэффициенты равны нулю


using System;

class QuadEqSolve
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите коэффициенты квадратного уравнения (a, b, c):");

        Console.Write("a: ");
        double coefA = Convert.ToDouble(Console.ReadLine());

        Console.Write("b: ");
        double coefB = Convert.ToDouble(Console.ReadLine());

        Console.Write("c: ");
        double coefC = Convert.ToDouble(Console.ReadLine());

       
        if (coefA == 0)
        {
            LinearEq(coefB, coefC);
        }
        else
        {
            rez(coefA, coefB, coefC);
        }
    }

    static void LinearEq(double b, double c)
    {
        if (b == 0)
        {
            if (c == 0)
            {
                Console.WriteLine("Уравнение имеет бесконечно много решений.");
            }
            else
            {
                Console.WriteLine("Уравнение не имеет решений.");
            }
        }
        else
        {
            double resh = -c / b;
            Console.WriteLine($"Уравнение имеет одно решение: x = {resh}");
        }
    }

    static void rez(double a, double b, double c)
    {
        double disc = b * b - 4 * a * c;

        if (disc > 0)
        {
            double root1 = (-b + Math.Sqrt(disc)) / (2 * a);
            double root2 = (-b - Math.Sqrt(disc)) / (2 * a);
            Console.WriteLine($"Уравнение имеет два различных решения: x1 = {root1}, x2 = {root2}");
        }
        else if (disc == 0)
        {
            double root = -b / (2 * a);
            Console.WriteLine($"Уравнение имеет одно решение: x = {root}");
        }
        else
        {
            Console.WriteLine("Уравнение не имеет действительных решений.");
        }
    }
}
