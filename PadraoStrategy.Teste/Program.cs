using PadraoStrategy.Negocio.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadraoStrategy.Teste
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculoFinanceiro objCalculoFinanceiro = new CalculoFinanceiro();            

            Console.WriteLine(string.Format("O imposto IPI sobre valor 1.000,00 é de {0}", objCalculoFinanceiro.RetornaImpostoIPI(1000.00)));
            Console.WriteLine(string.Format("O imposto ISS sobre valor 1.000,00 é de {0}", objCalculoFinanceiro.RetornaImpostoISS(1000.00)));
            Console.WriteLine(string.Format("O imposto ICMS sobre valor 1.000,00 é de {0}", objCalculoFinanceiro.RetornaImpostoICMS(1000.00)));
            Console.ReadKey();
        }
    }
}
