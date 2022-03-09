using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio05.ConsoleApp
{
    internal class Esfera
    {
        double _volume;
        double _raio;
        const double _pi = Math.PI;

        public double Raio
        {
            get
            {
                return _raio; ;
            }

            set
            {
                _raio = value;

            }
        }

        public double CalcularVolume()
        {
            _volume = (4 / 3) * _pi * Math.Pow(Raio, 3);

            return _volume;
        }
    }
}
