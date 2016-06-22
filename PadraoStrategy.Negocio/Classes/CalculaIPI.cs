using PadraoStrategy.Modelo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadraoStrategy.Negocio.Classes
{
    public class CalculaIPI : IImpostoComportamento
    {
        public double CalculaImposto(double valor)
        {
            //Calculo de retorno é Fictício
            return valor * 0.15;
        }
    }
}
