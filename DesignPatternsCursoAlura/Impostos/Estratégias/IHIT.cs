using DesignPatternsCursoAlura.Descontos_CoR_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsCursoAlura.Impostos.Estratégias
{
    class IHIT : Imposto
    {
        public IHIT(Imposto OutroImposto) : base(OutroImposto) { }

        public IHIT()
        {

        }
        public override double Calcula(Orcamento orcamento)
        {
            int qntd = ExisteDoisItensComMesmoNome(orcamento);
            if (qntd >= 2)
            {
                return orcamento.Valor * 0.13 + 100 + CalculoDoOutroImposto(orcamento);
            }
            else
            {
                return orcamento.Valor * (0.01 * orcamento.Itens.Count()) + CalculoDoOutroImposto(orcamento);
            }
        }

        public int ExisteDoisItensComMesmoNome(Orcamento orcamento)
        {
            int quantidade = 0;
            foreach(Item item in orcamento.Itens)
            {
                if (item.Nome.Equals("LAPIS"))
                {
                    quantidade++;
                }
            }

            return quantidade;
        }
    }
}
