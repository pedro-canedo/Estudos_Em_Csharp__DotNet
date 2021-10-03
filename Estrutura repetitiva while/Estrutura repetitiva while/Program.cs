using System;
using System.Globalization;

namespace Estrutura_repetitiva_while
{
    class Program
    {
        static void Main(string[] args)
        {
            String continuar = null;           
            Console.Write("Deseja iniciar o programa? 'S' para sim e 'N' para não: ");
            continuar = Console.ReadLine().ToUpper();
            while (continuar == "S")
            {
                Console.Write("Digite um número: ");
                double x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                double raiz = Math.Sqrt(x);
                Console.WriteLine($"A raiz quadrada deste número é: {raiz.ToString("F2", CultureInfo.InvariantCulture)}");
                Console.WriteLine("Continuar ?: 'S' para sim e 'N' para não");
                continuar = Console.ReadLine().ToUpper();
            }
            Console.WriteLine("Programa encerrado");
        }
    }
}
