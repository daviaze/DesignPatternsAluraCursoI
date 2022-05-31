using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsCursoAlura.Impostos.Templates
{
    //Padrão Template Method, muito utilizado quando se tem métodos repetidos em classes diferentes
    //Quando temos diferentes algoritmos que possuem estruturas parecidas, o Template Method é uma boa solução.
    //Com ele, conseguimos definir, em um nível mais macro, a estrutura do algoritmo e deixar "buracos",
    //que serão implementados de maneira diferente por cada uma das implementações específicas.
    public abstract class TemplateDeImpostoCondicional : Imposto
    {
        public TemplateDeImpostoCondicional(Imposto OutroImposto) : base(OutroImposto) { }

        public TemplateDeImpostoCondicional() : base()
        {

        }

        public override double Calcula(Orcamento orcamento)
        {
            if (DeveUsarMaximaTaxacao(orcamento))
            {
                return MaximaTaxacao(orcamento);
            }
            else
            {
                return MinimaTaxacao(orcamento);
            }
        }

        public abstract bool DeveUsarMaximaTaxacao(Orcamento orcamento);
        public abstract double MaximaTaxacao(Orcamento orcamento);
        public abstract double MinimaTaxacao(Orcamento orcamento);
    }
}
