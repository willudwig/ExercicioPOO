using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03.ConsoleApp
{
    public class Cilindro
    {
        double _volume;
        double _altura;
        double _raio;
        double _areabase;
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

        public double CalcularVolumeCilindro()
        {
            _areabase = pi * Math.Pow(Raio,2) * Altura;
            _volume = _areabase * Altura;
            return _volume;
        }
    }
}
