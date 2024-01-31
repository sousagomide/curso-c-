using System;

namespace Condicional {
    class Exercicio03 {
        static void Main(string[] args) {
            string[] dados = Console.ReadLine().Split(' ');
            int a = int.Parse(dados[0]);
            int b = int.Parse(dados[1]);
            if ((a % b == 0) || (b % a == 0))
                Console.WriteLine("Sao Multiplos");
            else
                Console.WriteLine("Nao sao Multiplos");
        }
    }
}
