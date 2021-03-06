using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsCursoAlura.Impostos.Estratégias
{
    class ICCC : Imposto
    {
        public ICCC()
        {

        }
        public ICCC(Imposto OutroImposto) : base(OutroImposto) { }

        public override double Calcula(Orcamento orcamento)
        {
            if (orcamento.Valor < 1000) return orcamento.Valor * 0.05;
            else if (orcamento.Valor >= 1000 && orcamento.Valor <= 3000) return orcamento.Valor * 0.07;
            else return orcamento.Valor * 0.08;
        }
    }
}
