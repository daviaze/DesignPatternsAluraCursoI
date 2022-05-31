using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsCursoAlura.Entities
{
    public class ICMS : Imposto
    {
        public ICMS()
        {

        }
        public ICMS(Imposto OutroImposto) : base(OutroImposto) { }

        public override double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 0.1;
        }
    }
}
