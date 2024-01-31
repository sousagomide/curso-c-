using System;
using System.Globalization;

namespace Sequencial {
    class Exercicio04 {
        static void Main(string[] args) {
            int id = int.Parse(Console.ReadLine());
            int horasTrabalhadas = int.Parse(Console.ReadLine());
            double valorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine($"NUMBER = {id}\nSALARY = U$ {(horasTrabalhadas * valorHora).ToString("F2", CultureInfo.InvariantCulture)}");
        } 
    }
}
