using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

/* 
 * LINK Correção: https://github.com/acenelio/nivelamento-csharp/blob/master/uri1010/uri1010/Program.cs
 * Fazer um programa para ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, o 
 * código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2. Calcule e mostre o valor a ser pago.
*/


namespace Ex01
{
    internal class Ex05
    {
        int cod1, cod2, qte1, qte2;
        double preco1, preco2, total;

        string[] valores = Console.ReadLine().Split(' ');
        cod1 = int.Parse(valores[0]);
        qte1 = int.Parse(valores[1]);
        preco1 = double.Parse(valores[2], CultureInfo.InvariantCulture);

        valores = Console.ReadLine().Split(' ');
        cod2 = int.Parse(valores[0]);
        qte2 = int.Parse(valores[1]);
        preco2 = double.Parse(valores[2], CultureInfo.InvariantCulture);

        total = preco1* qte1 + preco2* qte2;

        Console.WriteLine("VALOR A PAGAR: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
    }
}
