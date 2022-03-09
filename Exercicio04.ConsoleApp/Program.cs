using System;

namespace Exercicio04.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsumoCombustivel consumo = new();

            consumo.KmInicial = 21265;
            consumo.KmFinal = 21453;
            consumo.LitrosGasolinaTanqueCheio = 51;

            consumo.CalcularConsumoCombustívelKm();
            
            Console.WriteLine("O consumo de combustível por Km foi de {0} litros", consumo.CalcularConsumoCombustívelKm());
            Console.ReadKey();
        }
    }
}
