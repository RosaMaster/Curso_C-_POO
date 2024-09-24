
using System.Globalization;

namespace ExerciseSessao05
{
    public class ContaBancaria
    {
        public string Numero { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        public ContaBancaria(string numero, string titular)
        {
            Numero = numero;
            Titular = titular;
        }

        public ContaBancaria(string numero, string titular, double saldo) : this(numero, titular)
        {
            Numero = numero;
            Titular = titular;
            Saldo = saldo;
        }

        

        public void Deposito(double valor)
        {
            Saldo += valor;
        }

        public void Saque(double valor)
        {
            Saldo -= valor + 5.0;
        }


        override public string ToString()
        {
            return "Conta "
                + Numero
                + ", Titular: "
                + Titular
                + ", Saldo: $ "
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
