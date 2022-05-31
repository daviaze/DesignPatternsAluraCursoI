using DesignPatternsCursoAlura.Investimentos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsCursoAlura.Investimentos.Estratégias
{
    public class Conservador : IInvestimento
    {
        public double Calcula(double valor)
        {
            return valor * 0.08;
        }
    }
}
