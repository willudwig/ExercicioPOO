using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio06.ConsoleApp
{
    public class ConversaoCelsiusFahrenheit
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

        public double CelsiusParaFahrenheit()
        {
            _grausFahrenheit = ((GrausCelsius * 1.8) + 32);

            return _grausFahrenheit;
        }
    }
}
