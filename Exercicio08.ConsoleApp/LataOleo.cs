using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio08.ConsoleApp
{
    public class LataOleo
    {
        double _volume;
        double _altura;
        double _raio;
        const double pi = Math.PI;

        public double Altura
        {
            get
            {
                return _altura;
            }
            set
            {
                _altura = value;
            }
        }

        public double Raio
        {
            get
            {
                return _raio;
            }
            set
            {
                _raio = value;
            }
        }

        public double CalcularVolume()
        {
            _volume = pi * Math.Pow(Raio, 2) * Altura;

            return _volume;
        }
    }
}
