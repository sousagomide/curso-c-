using System;

namespace Sequencial {
    class Exercicio02 {
        static void Main(string[] args) {
            double raio = double.Parse(Console.ReadLine());
            double area = Math.PI * Math.Pow(raio, 2);
            Console.WriteLine($"A = {area}");
        }
    }
}
