using System;
using System.Globalization;

namespace Banco {
    class Program {
        static void Main(string[] args) {
            Console.Write("Entre o número da conta: ");
            string numero = Console.ReadLine();
            Console.Write("Entre o titular da conta: ");
            string nome = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n)? ");
            string resposta = Console.ReadLine();
            Conta c = null;
            if (resposta == "s") {
                Console.Write("Entre o valor de depósito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                c = new Conta(numero, nome, depositoInicial);
            } else {
                c = new Conta(numero, nome);
            }
            Console.WriteLine("Dados da conta:");
            Console.WriteLine(c);
            Console.Write("Entre um valor para depósito: ");
            c.deposito(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(c);
            Console.Write("Entre um valor para saque: ");
            c.saque(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(c);
        }
    }
}