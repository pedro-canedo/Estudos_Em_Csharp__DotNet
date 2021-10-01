using System;
using System.Globalization;

namespace Entrada_de_Dados
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual seu nome ? ");
            string nome = Console.ReadLine();
            Console.Write("Qual a sua idade: ");
            int idade = int.Parse(Console.ReadLine());
            Console.Write("Digite seu Sexo(M)(F) Ou (N): ");
            char sexo = char.Parse(Console.ReadLine());
            Console.Write("Qual a sua altura: ");
            double altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("Confirmando dados");
            Console.WriteLine($"Seu nome é {nome}");
            Console.WriteLine($"Sua idade é {idade}");
            Console.WriteLine($"Sua altura é {altura}cm");
            Console.WriteLine($"Seu sexo é {sexo}");



        }
    }
}
