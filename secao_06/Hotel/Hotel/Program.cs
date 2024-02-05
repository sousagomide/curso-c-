using System;

namespace Hotel {
    class Program {
        static void Main(string[] args) {
            Quarto[] quartos = new Quarto[10];
            Console.Write("Digite a quantidade de estudantes: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++) {
                Console.WriteLine($"Rent #{i}");
                Console.Write("Name: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Room: ");
                int numero = int.Parse(Console.ReadLine());
                quartos[numero] = new Quarto(numero, new Pessoa(nome, email));
                Console.WriteLine();
            }
            Console.WriteLine("\n\nBusy rooms:");
            for (int i = 0; i < quartos.Length; i++)
                if (quartos[i] != null)
                    Console.WriteLine(quartos[i].ToString());
        }
    }
}