

using System.Globalization;

namespace ExerciseSessao05
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria conta;

            Console.Write("Entre o número da conta: ");
            string numero = Console.ReadLine();
            Console.Write("Entre o titular da conta: ");
            string titular = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n)? ");
            char resp = char.Parse(Console.ReadLine());

            if (resp == 's' || resp == 'S' || resp == 'y' || resp == 'Y')
            {
                Console.Write("Entre o valor de depósito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new ContaBancaria(numero, titular, depositoInicial);
            }
            else
            {
                conta = new ContaBancaria(numero, titular);
            }

            Console.WriteLine();
            Console.WriteLine("Dados da conta:");
            Console.WriteLine(conta);

            char end = 's';

            while (end == 's' || end == 'S' || end == 'y' || end == 'Y')
            {
                Console.Write("Gostaria de realizar um Deposito/Saque (s/n)? ");
                end = char.Parse(Console.ReadLine());

                if (end == 's' || end == 'S' || end == 'y' || end == 'Y')
                {
                    Console.WriteLine();
                    Console.Write("Entre um valor para depósito: ");
                    double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    conta.Deposito(quantia);
                    Console.WriteLine("Dados da conta atualizados:");
                    Console.WriteLine(conta);

                    Console.WriteLine();
                    Console.Write("Entre um valor para saque: ");
                    quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    if (quantia != 0)
                    {
                        if (conta.Saldo >= quantia)
                        {
                            conta.Saque(quantia);
                            Console.WriteLine("Dados da conta atualizados:");
                            Console.WriteLine(conta);
                        }
                        else
                        {
                            Console.WriteLine("Saldo insuficiente!!! Entre em contato com o gerente da conta!!!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Agradecemos a preferência!!!");
                    }
                    
                }
                else
                {
                    Console.WriteLine("Agradecemos a preferência!!!");
                }
            }
        }
    }
}