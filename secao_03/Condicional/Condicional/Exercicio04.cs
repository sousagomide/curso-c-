using System;

namespace Condicional {
    class Exercicio04 {
        static void Main(string[] args) {
            string[] dados = Console.ReadLine().Split(' ');
            int inicial = int.Parse(dados[0]);
            int final = int.Parse(dados[1]);
            int hora = 0;

            if (inicial < final)
                hora = final - inicial;
            else if (inicial >= final)
                hora = (24 - inicial) + final;
            Console.WriteLine($"O JOGO DUROU {hora} HORA(S)");
        }
    }
}
