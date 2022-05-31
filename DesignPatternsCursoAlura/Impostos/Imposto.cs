using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsCursoAlura
{
    public abstract class Imposto
    {
        public Imposto OutroImposto { get; set; }
        public Imposto()
        {

        }
        //Padrão Decorator
        //Quando compomos comportamento, através de classes que recebem objetos do mesmo tipo
        //que elas mesmas (nesse caso, ISS que é um Imposto, recebe em seu construtor outro Imposto)
        //para fazerem parte de seu comportamento, de uma maneira que seu uso é definido a partir do
        //que se passou para a instanciação dos objetos, é o que caracteriza o Design Pattern chamado Decorator

        /*
         Sempre que percebemos que temos comportamentos que podem ser compostos por comportamentos de outras classes
        envolvidas em uma mesma hierarquia, como foi o caso dos impostos, que podem ser composto por outros impostos.
        O Decorator introduz a flexibilidade na composição desses comportamentos, bastando escolher no momento da instanciação,
        quais instancias serão utilizadas para realizar o trabalho.
         */
        public Imposto(Imposto OutroImposto)
        {
            this.OutroImposto = OutroImposto;
        }
        public abstract double Calcula(Orcamento orcamento);
        protected double CalculoDoOutroImposto(Orcamento orcamento)
        {
            return OutroImposto.Calcula(orcamento);
        }
    }
}
