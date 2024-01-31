using System;

namespace Condicional {
    class Exercicio02 {
        static void Main(string[] args) {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine((n % 2 == 0 ? "PAR" : "IMPAR"));
        }
    }
}
