using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 
 * LINK Correção: https://github.com/acenelio/nivelamento-csharp/blob/master/uri1003/uri1003/Program.cs
 * Faça um programa para ler dois valores inteiros, e depois mostrar na tela a soma desses números com uma mensagem explicativa, conforme exemplos.
*/

namespace Ex01
{
    internal class Ex01
    {
        int A, B, soma;

        A = int.Parse(Console.ReadLine());
        B = int.Parse(Console.ReadLine());

        soma = A + B;

            Console.WriteLine("SOMA = " + soma);
    }
}
