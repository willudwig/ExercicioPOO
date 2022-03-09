using System;

namespace Exercicio09.ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            MediaHarmonica aluno = new();

            double media = aluno.CalcularMediaHarmonica(7.5, 8.0, 6.0, 9.0);
            
            Console.WriteLine($"a média harmônica é: {media:N2}");
            Console.ReadKey();
        }
    }
}
