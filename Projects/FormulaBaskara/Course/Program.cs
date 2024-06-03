using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 1.0, b = -3.0, c = -4.0;

            Console.WriteLine($"f(x) = {a:F0}x² + {b:F0}x + {c:F0}");
            Console.WriteLine();

            Console.WriteLine("Fórmula de Baskara");
            Console.WriteLine();
            Console.WriteLine("delta = b² - 4 * a * c");
            Console.WriteLine();
            Console.WriteLine("X = - b +- Sqrt[ delta ] / 2 * a");
            Console.WriteLine();

            double delta = Math.Pow(b, 2.0) - 4.0 * a * c;

            Console.WriteLine($"Delta = {delta:F2}");

            double x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);

            Console.WriteLine($"X1 = {x1:F2}");

            double x2 = (-b - Math.Sqrt(delta)) / (2.0 * a);

            Console.WriteLine($"X2 = {x2:F2}");
        }
    }
}
