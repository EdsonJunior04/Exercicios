using System;

namespace Exercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual o ano de nascimento ?");
            int anoNascimento = Convert.ToInt32(Console.ReadLine());
            int anoAtual = DateTime.Now.Year;

            int idade = anoAtual - anoNascimento;
            int bissexto = idade / 4;
            int idadeDias = idade * 365 + bissexto;
            int idadeSemana = idadeDias/7;

            Console.WriteLine($"Você tem {idade} anos.\nE {idadeSemana} semanas");
        }
    }
}
