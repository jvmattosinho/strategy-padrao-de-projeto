using PadraoStrategy.Modelo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadraoStrategy.Modelo.Classes
{
    public abstract class Imposto
    {
        public IImpostoComportamento ImpostoIPI;

        public IImpostoComportamento ImpostoISS;

        public IImpostoComportamento ImpostoICMS;

        public Imposto()
        {

        }

        public abstract double RetornaImpostoIPI(double valor);
        public abstract double RetornaImpostoISS(double valor);
        public abstract double RetornaImpostoICMS(double valor);
    }
}
