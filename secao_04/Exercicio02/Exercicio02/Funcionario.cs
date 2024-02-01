using System.Globalization;

namespace Exercicio02 {
    class Funcionario {

        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido() {
            return this.SalarioBruto - this.Imposto;
        }

        public void AumentarSalario(double porcentagem) {
            this.SalarioBruto = (1 + (porcentagem / 100.0)) * this.SalarioBruto;
        }

        public override string ToString() {
            return $"{this.Nome}, $ {this.SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture)}";
        }

    }
}
