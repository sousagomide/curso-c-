using System;

namespace Hotel {
    class Quarto {

        public int? Numero { get; set; }
        public Pessoa Pessoa { get; set; }

        public Quarto(int numero, Pessoa pessoa) {
            Numero = numero;
            Pessoa = pessoa;
        }

        public override string ToString() {
            return $"{Numero}: {Pessoa.Nome}, {Pessoa.Email}";
        }
    }
}
