using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio10.ConsoleApp
{
    public class MediaPonderada
    {
        double _media;
        public double[] Peso { get; set; }
        public double CalcularMediaHarmonica(params double[] notas )
        {
            double somaNotas = 0;
            double somaPesos = 0;

            if (notas.Length < 2)
            {
                Console.WriteLine("Parâmetros insuficiêntes para cálculo!");
            }
            else
            {
                for (int i = 0; i < notas.Length; i++)
                {
                    somaNotas += notas[i] * Peso[i];
                    somaPesos += Peso[i];
                }

                _media = somaNotas / somaPesos;
            }

            return _media;
        }
    }
}
