using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsCursoAlura.Investimentos.Interfaces
{
    public interface IInvestimento
    {
        public double Calcula(double valor);
    }
}
