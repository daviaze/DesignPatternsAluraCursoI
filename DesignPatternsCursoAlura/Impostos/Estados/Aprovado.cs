using DesignPatternsCursoAlura.Impostos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsCursoAlura.Impostos.Estados
{
    public class Aprovado : IEstado
    {
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            orcamento.Valor -= orcamento.Valor * 0.02;
        }

        public void Aprova(Orcamento orcamento)
        {
            throw new Exception("Este orçamento já está aprovado!");
        }

        public void Reprova(Orcamento orcamento)
        {
            throw new Exception("Este orçamento não pode ser reprovado, pois já está aprovado!");
        }

        public void Finaliza(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new Finalizado();
        }
    }
}
