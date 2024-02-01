using System;
using System.Globalization;

namespace Condicional {
    class Exercicio06 {
        static void Main(string[] args) {
            double n = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            string r = "";
            if (n >= 0 && n <= 25)
                r = "Intervalo [0, 25]";
            else if (n > 25 && n <= 50)
                r = "Intervalo (25, 50]";
            else if (n > 50 && n <= 75)
                r = "Intervalo (50, 75]";
            else if (n > 75 && n <= 100)
                r = "Intervalo (75, 100]";
            else
                r = "Fora de intervalo";
            Console.WriteLine(r);


        }
    }
}
