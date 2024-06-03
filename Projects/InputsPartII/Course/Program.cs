using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero inteiro: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite um caracter: ");
            char ch = char.Parse(Console.ReadLine());
            Console.WriteLine("Digite um numero com ponto flutuante: ");
            double number2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite seu nome | sexo | idade | altura: ");
            string[] vet = (Console.ReadLine()).Split(' ');

            Console.WriteLine("Você digitou: ");
            Console.WriteLine(number);
            Console.WriteLine(ch);
            Console.WriteLine(number2.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(vet[0]);
            Console.WriteLine(vet[1]);
            Console.WriteLine(vet[2]);
            Console.WriteLine(vet[3]);
        }
    }
}
