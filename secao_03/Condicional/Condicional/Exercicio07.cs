using System;
using System.Globalization;

namespace Condicional {
    class Exercicio07 {
        static void Main(string[] args) {
            string[] data = Console.ReadLine().Split(' ');
            double x = double.Parse(data[0], CultureInfo.InvariantCulture);
            double y = double.Parse(data[1], CultureInfo.InvariantCulture);
            string saida = "";
            if (x == 0.0 && y == 0.0)
                saida = "Origem";
            else if (x == 0.0 && y != 0.0)
                saida = "Eixo Y";
            else if (x != 0.0 && y == 0.0)
                saida = "Eixo X";
            else if (x > 0.0 && y > 0.0)
                saida = "Q1";
            else if (x < 0.0 && y > 0.0)
                saida = "Q2";
            else if (x < 0.0 && y < 0.0)
                saida = "Q3";
            else
                saida = "Q4";
            Console.WriteLine(saida);
        }
    }
}
