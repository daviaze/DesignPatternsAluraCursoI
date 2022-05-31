using DesignPatternsCursoAlura.Impostos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DesignPatternsCursoAlura.Impostos.Estados
{
    public class Finalizado : IEstado
    {
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            throw new Exception("Orçamentos finalizados não recebem desconto extra!");
        }

        public void Aprova(Orcamento orcamento)
        {
            throw new Exception("Este orcamento já está finalizado!");
        }
        public void Reprova(Orcamento orcamento)
        {
            throw new Exception("Este orcamento já está finalizado!");
        }
        public void Finaliza(Orcamento orcamento)
        {
            throw new Exception("Este orcamento já está finalizado!");
        }
    }
}
