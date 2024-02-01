﻿using System;
using System.Globalization;

namespace Exercicio03 {
    class Program {
        static void Main(string[] args) {
            Aluno a = new Aluno(60.0);
            Console.Write("Nome do aluno: ");
            a.Nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno:");
            a.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            a.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            a.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine($"NOTA FINAL = {a.NotaFinal().ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine(a.Situacao());

        }
    }
}