using System;

namespace Exercicio01 {
    class Retangulo {

        public double Largura;
        public double Altura;

        public double Area() {
            return this.Largura * this.Altura;
        }

        public double Perimetro() {
            return 2.0 * (this.Largura + this.Altura);
        }

        public double Diagonal() {
            return Math.Sqrt(Math.Pow(this.Largura, 2) + Math.Pow(this.Altura, 2));
        }

        public override string ToString() {
            return $"Retângulo => Largura: {this.Largura}; Altura: {this.Altura}";
        }

    }
}
