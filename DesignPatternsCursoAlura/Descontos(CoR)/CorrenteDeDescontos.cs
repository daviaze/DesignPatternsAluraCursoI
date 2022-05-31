using DesignPatternsCursoAlura.Descontos_CoR_.Handlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsCursoAlura.Descontos_CoR_
{
    public class CorrenteDeDescontos
    {
        //Chain of Responsability - Cadeia de chamadas, em que a comunicação entre os handlers
        //serão definidas na classe CorrenteDeDescontos, e a interface em comum irá conecta-los;
        //Exemplo de utilização deste padrão: Sistema bancário, em que é utilizado várias verificações em cadeia
        //para atendar a qualquer tipo de solicitação;

        //O padrão Chain of Responsibility cai como uma luva quando temos uma lista de comandos a serem executados
        //de acordo com algum cenário em específico, e sabemos também qual o próximo cenário que deve ser validado,
        //caso o anterior não satisfaça a condição.
        public double Calcula(Orcamento orcamento)
        {
            IDesconto d1 = new DescontoPorCincoItens();
            IDesconto d2 = new DescontoPorMaisDeQuinhentosReais();
            IDesconto d3 = new DescontoPorVendaCasada();

            d1.Proximo = d2;
            d2.Proximo = d3;

            return d1.Desconta(orcamento);
        }
    }
}
