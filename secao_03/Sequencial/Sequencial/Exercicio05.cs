using System;
using System.Globalization;

namespace Sequencial {
    class Exercicio05 {
        static void Main(string[] args) {
            string[] dados1 = Console.ReadLine().Split(' ');
            string[] dados2 = Console.ReadLine().Split(' ');
            double total = double.Parse(dados1[1]) * double.Parse(dados1[2], CultureInfo.InvariantCulture) + 
                           double.Parse(dados2[1]) * double.Parse(dados2[2], CultureInfo.InvariantCulture);
            Console.WriteLine($"VALOR A PAGAR: R$ {total.ToString("F2", CultureInfo.InvariantCulture)}");

        }
    }
}
