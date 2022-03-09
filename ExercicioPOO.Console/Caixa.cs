using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01.ConsoleApp
{
    public class Caixa
    {
        double _altura;
        double _comprimento;
        double _largura;
        double _volume;

        public double Altura
        {
            get
            {
                return _altura;
            }

            set
            {
                try
                {
                    _altura = value;
                }
                catch (FormatException)
                {
                    System.Console.WriteLine("\nFormato inválido, digite apenas números\n");
                }
            }

        }
        public double Comprimento
        {
            get
            {
                return _comprimento; ;
            }

            set
            {
                _comprimento = value;

            }

        }
        public double Largura
        {
            get
            {
                return _largura; ;
            }

            set
            {
                _largura = value;
            }
        }

        public double CalcularVolume()
        {
            _volume = Comprimento * Largura * Altura;

            return _volume;
        }

    }
}
