using DesignPatternsCursoAlura.Investimentos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsCursoAlura.Investimentos.Contexto
{
    public class CalculadorDeInvestimentos
    {
        public CalculadorDeInvestimentos(double valor, IInvestimento investimento)
        {
            Console.WriteLine(investimento.Calcula(valor));
        }
    }
}
