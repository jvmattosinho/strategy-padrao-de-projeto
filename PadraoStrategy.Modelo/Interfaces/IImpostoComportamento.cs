using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadraoStrategy.Modelo.Interfaces
{
    public interface IImpostoComportamento
    {
        double CalculaImposto(double valor);
    }
}
