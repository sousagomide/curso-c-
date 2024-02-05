using System;

namespace Hotel {
    class Pessoa {
        public string Nome { get; set; }
        public string Email { get; set; }
        
        public Pessoa(string nome, string email) {
            Nome = nome;
            Email = email;
        }

        public override string ToString() {
            return $"Name: {Nome}\nEmail: {Email}";
        }
    }
}
