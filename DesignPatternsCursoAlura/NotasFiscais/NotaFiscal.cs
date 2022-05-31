using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsCursoAlura.NotasFiscais
{
    public class NotaFiscal
    {
        public NotaFiscal(string razaoSocial, string cNPJ, double totalNota, List<Item> itens, double descontoTotal)
        {
            RazaoSocial = razaoSocial;
            CNPJ = cNPJ;
            TotalNota = totalNota;
            Itens = itens;
            DescontoTotal = descontoTotal;
        }

        public NotaFiscal()
        {
            Itens = new List<Item>();
            executas = new List<IExecuta>();
        }
        public string RazaoSocial { get; private set; }
        public string CNPJ { get; set; }
        public double TotalNota { get; set; }
        public List<Item> Itens { get; set; }
        public double DescontoTotal { get; set; }
        public List<IExecuta> executas { get; set; }

        public void ComEnvio(IExecuta executa)
        {
            executas.Add(executa);
        }
        public void ComRazaoSocial(string razaosocial)
        {
            this.RazaoSocial = razaosocial;
        }
        public void ComCNPJ(string cnpj)
        {
            this.CNPJ = cnpj;
        }
        public void comItem(Item item)
        {
            Itens.Add(item);
            TotalNota += item.Valor;
        }
        public void comDesconto(double desconto)
        {
            this.DescontoTotal = desconto;
            TotalNota -= desconto;
        }

        public NotaFiscal Constroi()
        {
            //Builder -> Utilizado para falicitar a construção do objeto, especialmente quando sua classe é muito complexa

             NotaFiscal notafiscal = new NotaFiscal(RazaoSocial, CNPJ, TotalNota, Itens, DescontoTotal);

            //Observer -> O Observer é um padrão de projeto comportamental que permite que um objeto
            //notifique outros objetos sobre alterações em seu estado.

            /*
             * O padrão Observer é bastante comum no código C#, especialmente nos componentes
             * da interface de usuário. Ele fornece uma maneira de reagir a eventos que acontecem
             * em outros objetos sem acoplamento às suas classes.
             */

            foreach (IExecuta ex in executas)
            {
                ex.Executa();
            }

            return notafiscal;
        }
    }
}
