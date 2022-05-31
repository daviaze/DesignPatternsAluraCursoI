using DesignPatternsCursoAlura.Investimentos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsCursoAlura.Investimentos.Estratégias
{
    public class Arrojado : IInvestimento
    {
        public double Calcula(double valor)
        {
            var chances = new Random().Next(101);

            if (chances < 20) return valor * 0.05;
            if (chances > 20 && chances < 50) return valor * 0.03;
            else return valor * 0.6;
        }
    }
}
