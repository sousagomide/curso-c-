using System;
using System.Globalization;

namespace Banco {
    class Conta {
        private double _saldo;
        public string Numero { get; private set; }
        public string Nome { get; set; }
        public double DepositoInicial { get; set; }
        
        public Conta(string numero, string nome) {
            Numero = numero;
            Nome = nome;
        }

        public Conta(string numero, string nome, double depositoInicial) : this(numero, nome) {
            DepositoInicial = depositoInicial;
            _saldo = DepositoInicial;
        }

        public void deposito(double valor) {
            _saldo += valor;
        }

        public void saque(double valor) {
            _saldo -= (valor + 5.00);
        }

        public override string ToString() {
            return $"Conta {Numero}, Titular: {Nome}, Saldo: $ {_saldo.ToString("F2", CultureInfo.InvariantCulture)}";
        }

    }
}
