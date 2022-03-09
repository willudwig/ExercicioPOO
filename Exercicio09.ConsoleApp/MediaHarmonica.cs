using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio09.ConsoleApp
{
    public class MediaHarmonica
    {
        double _media;

        public double CalcularMediaHarmonica(params double[] notas )
        {
            double somaNotasInversas = 0;

            if (notas.Length < 2)
            {
                Console.WriteLine("Parâmetros insuficiêntes para cálculo!");
            }
            else
            {
                for (int i = 0; i < notas.Length; i++)
                {
                    somaNotasInversas += 1 / notas[i];
                }

                _media = notas.Length / somaNotasInversas;
            }

            return _media;
        }
      
    }
}
