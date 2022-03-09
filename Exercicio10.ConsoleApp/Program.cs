using System;

namespace Exercicio10.ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            MediaPonderada aluno = new();

            aluno.Peso = new double[] { 2.5, 4.0 };
            
            double media = aluno.CalcularMediaHarmonica(7.0, 8.0);

            Console.WriteLine($"A média ponderada é {media:N2}");
            Console.ReadKey();
        }
    }
}
