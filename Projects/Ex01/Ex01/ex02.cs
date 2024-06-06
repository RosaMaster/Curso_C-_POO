using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

/* 
 * LINK Correção: https://github.com/acenelio/nivelamento-csharp/blob/master/uri1002/uri1002/Program.cs
 * Faça um programa para ler o valor do raio de um círculo, e depois mostrar o valor da área deste círculo com quatro
 * casas decimais conforme exemplos.
 * Fórmula da área: area = π . raio2
 * Considere o valor de π = 3.14159
*/

namespace Ex01
{
    internal class Ex02
    {
        double R, A, pi = 3.14159;

        R = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        A = (pi * R * R);

        Console.WriteLine("A=" + A.ToString("F4", CultureInfo.InvariantCulture));
    }
}
