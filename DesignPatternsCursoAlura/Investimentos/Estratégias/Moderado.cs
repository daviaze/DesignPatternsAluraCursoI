using DesignPatternsCursoAlura.Investimentos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsCursoAlura.Investimentos.Estratégias
{
    public class Moderado : IInvestimento
    {
        public double Calcula(double valor)
        {
            var chances = new Random().Next(101);

            if (chances > 50) return valor * 0.025;
            else return valor * 0.07;
        }
    }
}
