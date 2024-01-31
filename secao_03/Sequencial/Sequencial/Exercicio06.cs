using System;
using System.Globalization;

namespace Sequencial {
    class Exercicio06 {
        static void Main(string[] args) {
            string[] dados = Console.ReadLine().Split(' ');
            double a = double.Parse(dados[0], CultureInfo.InvariantCulture);
            double b = double.Parse(dados[1], CultureInfo.InvariantCulture);
            double c = double.Parse(dados[2], CultureInfo.InvariantCulture);
            double areaTriangulo = (a * c) / 2;
            double areaCirculo = Math.PI * Math.Pow(c, 2);
            double areaTrapezio = (a + b) * c / 2;
            double areaQuadrado = Math.Pow(b, 2);
            double areaRetangulo = a * b;
            Console.WriteLine(
                $"TRIANGULO: {areaTriangulo.ToString("F3", CultureInfo.InvariantCulture)}\n" +
                $"CIRCULO: {areaCirculo.ToString("F3", CultureInfo.InvariantCulture)}\n" + 
                $"TRAPEZIO: {areaTrapezio.ToString("F3", CultureInfo.InvariantCulture)}\n" +
                $"QUADRADO: {areaQuadrado.ToString("F3", CultureInfo.InvariantCulture)}\n" +
                $"RETANGULO: {areaRetangulo.ToString("F3", CultureInfo.InvariantCulture)}"
            );
        }
    }
}
