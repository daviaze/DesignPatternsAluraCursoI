using DesignPatternsCursoAlura.Impostos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsCursoAlura.Impostos.Estados
{
    public class Reprovado : IEstado
    {
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            throw new Exception("Orçamentos reprovados não recebem desconto extra!");
        }

        public void Aprova(Orcamento orcamento)
        {
            throw new Exception("Este orçamento já está reprovado!");
        }

        public void Reprova(Orcamento orcamento)
        {
            throw new Exception("Este orçamento já está reprovado!");
        }

        public void Finaliza(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new Finalizado();
        }
    }
}
