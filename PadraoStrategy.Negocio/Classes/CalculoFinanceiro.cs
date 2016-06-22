using PadraoStrategy.Modelo.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadraoStrategy.Negocio.Classes
{
    public class CalculoFinanceiro : Imposto
    {
        public CalculoFinanceiro()
        {
            this.ImpostoIPI = new CalculaIPI();
            this.ImpostoISS = new CalculaISS();
            this.ImpostoICMS = new CalculaICMS();
        }

        public override double RetornaImpostoICMS(double valor)
        {
            return ImpostoICMS.CalculaImposto(valor);
        }

        public override double RetornaImpostoIPI(double valor)
        {
            return ImpostoIPI.CalculaImposto(valor);
        }

        public override double RetornaImpostoISS(double valor)
        {
            return ImpostoISS.CalculaImposto(valor);
        }
    }
}
