using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02ConsoleApp
{
    public class ConversaoFahrenheitCelsius
    {
        double _grausCelsius;
        double _grausFahrenheit;

        public double GrausCelsius
        {
            get
            {
                return _grausCelsius;
            }

            set
            {
                while (true)
                {
                    try
                    {
                        _grausCelsius = value;
                        break;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("\nFormato inválido, digite apenas números\n");
                        continue;
                    }
                }

            }
        }

        public double GrausFahrenheit
        {
            get
            {
                return _grausFahrenheit;
            }

            set
            {
                while (true)
                {
                    try
                    {
                        _grausFahrenheit = value;
                        break;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("\nFormato inválido, digite apenas números\n");
                        continue;
                    }
                }

            }
        }

        public double FahrenheitParaCelsius()
        {
            GrausCelsius = ( (GrausFahrenheit - 32) / 1.8 );

            return GrausCelsius; 
        }

        public ConversaoFahrenheitCelsius()
        {
            Console.Title = "Conversor";
            Console.WriteLine("Entre com o valor em graus Fahrenheit:\n");
        }
    }
}
