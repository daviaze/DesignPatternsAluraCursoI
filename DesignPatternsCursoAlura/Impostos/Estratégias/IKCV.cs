using DesignPatternsCursoAlura.Descontos_CoR_;
using DesignPatternsCursoAlura.Impostos.Templates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsCursoAlura.Impostos.Estratégias
{
    class IKCV : TemplateDeImpostoCondicional
    {
        public IKCV(Imposto OutroImposto) :base(OutroImposto)
        {

        }
        public override bool DeveUsarMaximaTaxacao(Orcamento orcamento)
        {
            bool deve = orcamento.Valor > 500 && TemItemMaiorQue100ReaisNo(orcamento);
            return deve;
        }

        public override double MaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.10 + CalculoDoOutroImposto(orcamento);
        }

        public override double MinimaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.06 + CalculoDoOutroImposto(orcamento);
        }

        private bool TemItemMaiorQue100ReaisNo(Orcamento orcamento)
        {
            foreach (Item item in orcamento.Itens)
            {
                if (item.Valor > 100)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
