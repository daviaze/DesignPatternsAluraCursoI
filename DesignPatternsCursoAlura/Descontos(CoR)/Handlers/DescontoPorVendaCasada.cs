using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsCursoAlura.Descontos_CoR_.Handlers
{
    class DescontoPorVendaCasada : IDesconto
    {
        public IDesconto Proximo { get; set; }

        public double Desconta(Orcamento orcamento)
        {
            bool existsLapis = Existe("LAPIS", orcamento);
            bool existsCaneta = Existe("CANETA", orcamento);

            if (existsLapis && existsCaneta)
            {
                return orcamento.Valor * 0.05;
            }
            else
            {
                return 0;
            }
        }

        public bool Existe(string nomeDoItem, Orcamento orcamento)
        {
            foreach(Item item in orcamento.Itens)
            {
                if (item.Nome.Equals(nomeDoItem)) return true;
            }
            return false;
        }
    }
}
