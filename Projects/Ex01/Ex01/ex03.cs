using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

/* 
 * LINK Correção: https://github.com/acenelio/nivelamento-csharp/blob/master/uri1007/uri1007/Program.cs
 * Fazer um programa para ler quatro valores inteiros A, B, C e D. A seguir, calcule e mostre a diferença do produto 
 * de A e B pelo produto de C e D segundo a fórmula: DIFERENCA = (A * B - C * D).
*/

namespace Ex01
{
    internal class Ex03
    {
        int A, B, C, D, DIFERENCA;

        A = int.Parse(Console.ReadLine());
        B = int.Parse(Console.ReadLine());
        C = int.Parse(Console.ReadLine());
        D = int.Parse(Console.ReadLine());

        DIFERENCA = (A * B - C * D);

        Console.WriteLine("DIFERENCA = " + DIFERENCA);
    }
}
