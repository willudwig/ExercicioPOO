using System;

namespace Exercicio03.ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Cilindro cilindro1 = new();

            cilindro1.Altura = 3;
            cilindro1.Raio = 5;

            Console.WriteLine("o volume do cilindro é: {0}", cilindro1.CalcularVolumeCilindro().ToString("N2")); ;
            Console.ReadKey();
        }
    }
}
