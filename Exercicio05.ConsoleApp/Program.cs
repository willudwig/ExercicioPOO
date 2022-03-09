using System;

namespace Exercicio05.ConsoleApp
{
   public class Program
    {
        static void Main(string[] args)
        {
            Esfera esf1 = new();
            
            esf1.Raio = 6;

            Console.WriteLine("O volume da esfera é {0}", esf1.CalcularVolume().ToString("N2"));
            Console.ReadKey();
        }
    }
}
