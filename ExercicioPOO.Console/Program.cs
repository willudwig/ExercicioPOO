using System;

namespace Exercicio01.ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Caixa caixaRetangular = new();

            caixaRetangular.Comprimento = 12;
            caixaRetangular.Largura = 10;
            caixaRetangular.Altura = 4;

            System.Console.WriteLine( $"O volume da caixa é {caixaRetangular.CalcularVolume():N2}" );

            System.Console.ReadKey();
            Environment.Exit(0);
        }
    }
}