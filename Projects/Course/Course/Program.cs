using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            string product1 = "Computer";
            string product2 = "Office desk";

            byte age = 30;
            int code = 5290;
            char genero = 'M';

            double price1 = 2100.0;
            double price2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine("Produtos:");
            Console.WriteLine($"{product1}, cujo preço é $ {price1:F2}");
            Console.WriteLine($"{product2}, cujo preço é $ {price2:F2}");
            Console.WriteLine();
            Console.WriteLine($"Registro: {age} anos de idade, código {code} e gênero: {genero}");
            Console.WriteLine();
            Console.WriteLine($"Medida com oito casas decimais: {medida:F8}");
            Console.WriteLine($"Arredondamento (três casa decimais): {medida:F3}");
            Console.WriteLine("Separador decimal invariant culture: " + medida.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
