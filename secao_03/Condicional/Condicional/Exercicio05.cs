using System;
using System.Globalization;

namespace Condicional {
    class Exercicio05 {
        static void Main(string[] args) {
            string[] dados = Console.ReadLine().Split(' ');
            int id = int.Parse(dados[0]);
            int quantidade = int.Parse(dados[1]);
            double total = 0.0;
            switch(id) {
                case 1:
                    total = 4.00 * quantidade;
                    break;
                case 2:
                    total = 4.50 * quantidade;
                    break;
                case 3:
                    total = 5.00 * quantidade;
                    break;
                case 4:
                    total = 2.00 * quantidade;
                    break;
                case 5:
                    total = 1.50 * quantidade;
                    break;
            }
            Console.WriteLine($"Total: R$ {total.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
