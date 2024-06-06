using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

/* 
 * LINK Correção: https://github.com/acenelio/nivelamento-csharp/blob/master/uri1008/uri1008/Program.cs
 * Fazer um programa que leia o número de um funcionário, seu número de horas trabalhadas, o valor que recebe por 
 * hora e calcula o salário desse funcionário. A seguir, mostre o número e o salário do funcionário, com duas casas 
 * decimais
*/

namespace Ex01
{
    internal class Ex04
    {
        int numero, horas;
        double valorHora, salario;

        numero = int.Parse(Console.ReadLine());
        horas = int.Parse(Console.ReadLine());
        valorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        salario = valorHora* horas;

        Console.WriteLine("NUMBER = " + numero);
        Console.WriteLine("SALARY = U$ " + salario.ToString("F2", CultureInfo.InvariantCulture));
    }
}
