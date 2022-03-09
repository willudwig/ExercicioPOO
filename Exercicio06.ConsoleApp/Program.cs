using System;

namespace Exercicio06.ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            ConversaoCelsiusFahrenheit temperatura = new();

            temperatura.GrausCelsius = 25;
           
            Console.WriteLine("{0}º Celsius em Fahrenheit é {1}ºF", temperatura.GrausCelsius, temperatura.CelsiusParaFahrenheit().ToString("N2"));
            Console.ReadKey();
        }
    }
}
