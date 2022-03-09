using System;

namespace Exercicio08.ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            LataOleo lata = new();

            lata.Altura = 10;
            lata.Raio = 5;

            Console.WriteLine($"O volume da lata é {lata.CalcularVolume():N2}");
            Console.ReadKey();
        }
    }
}
