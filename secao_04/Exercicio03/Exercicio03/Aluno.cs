using System;
using System.Globalization;

namespace Exercicio03 {
    class Aluno {

        public string Nome;
        public double Nota1;
        public double Nota2;
        public double Nota3;
        public double Media;

        public Aluno(double media) { 
            this.Media = media;
        }


        public double NotaFinal() {
            return this.Nota1 + this.Nota2 + this.Nota3;
        }

        public string Situacao() {
            double nf = this.NotaFinal();
            if (nf >= this.Media)
                return "APROVADO";
            else
                return $"REPROVADO\nFALTARAM {(this.Media - nf).ToString("F2", CultureInfo.InvariantCulture)} PONTOS";
        }
    }
}
