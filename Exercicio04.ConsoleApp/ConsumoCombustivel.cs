using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio04.ConsoleApp
{
    public class ConsumoCombustivel
    {
        int _kmInicial;
        int _kmFinal;
        int _kmRodado;
        int _litrosGasolinaTanquecheio;

        public int KmInicial
        {
            get { return _kmInicial; }
            set { _kmInicial = value; }
        }
        public int KmFinal
        {
            get { return _kmFinal; }
            set { _kmFinal = value; }
        }
        public int LitrosGasolinaTanqueCheio
        {
            get { return _litrosGasolinaTanquecheio; }
            set { _litrosGasolinaTanquecheio = value; }
        }

        public int CalcularConsumoCombustívelKm()
        {
            _kmRodado = KmFinal - KmInicial;
            return _kmRodado / LitrosGasolinaTanqueCheio;
        }

    }
}
