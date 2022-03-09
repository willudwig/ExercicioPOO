using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio07.ConsoleApp
{
    public class SalarioVendedor
    {
        /*
         *  calcular o salário total de um vendedor. 
         *  Deverá ser informado o salário base e o total e vendas.
         *  A comissão é calculada com um percentual (informado pelo usuário) sobre o total de vendas.
         */

        double _salariototal;    
        double _totalVendas;
        double _percentualComissao;
        const double _salariobase = 1200.00;

        public double PercentualComissao
        {
            get { return _percentualComissao; }
            set { _percentualComissao = value; }            
        }
        public double TotalVendas
        {
            get { return _totalVendas; }
            set { _totalVendas = value;}
        }

        public double CalcularSalarioTotal()
        {
            _salariototal = ( TotalVendas * (PercentualComissao/100) ) + _salariobase;

            return _salariototal;
        }

    }
}
