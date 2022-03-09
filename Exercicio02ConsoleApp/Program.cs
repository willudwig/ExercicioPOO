using System;

namespace Exercicio02ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            //instância do objeto
            ConversaoFahrenheitCelsius conversao = new();

            //input
            Console.Write("> ");
            conversao.GrausFahrenheit = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\n{0}º Fahrenheit é equivalente a {1}º Celsius",conversao.GrausFahrenheit, conversao.FahrenheitParaCelsius().ToString("N2"));

            Console.ReadKey();
            Environment.Exit(0);
        }
    }
}
