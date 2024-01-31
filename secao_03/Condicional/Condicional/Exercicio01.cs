using System;

namespace Condicional {
    class Exercicio01 {
        static void Main(string[] args) { 
            int n = int.Parse(Console.ReadLine());
            if (n < 0)
                Console.WriteLine("NEGATIVO");
            else
                Console.WriteLine("NAO NEGATIVO");
        }
    }
}