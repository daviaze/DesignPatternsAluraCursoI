using DesignPatternsCursoAlura.Descontos_CoR_;
using DesignPatternsCursoAlura.Entities;
using DesignPatternsCursoAlura.Impostos;
using DesignPatternsCursoAlura.Impostos.Estratégias;
using DesignPatternsCursoAlura.Investimentos.Contexto;
using DesignPatternsCursoAlura.Investimentos.Estratégias;
using DesignPatternsCursoAlura.NotasFiscais;
using System;

namespace DesignPatternsCursoAlura
{
    class Program
    {
        static void Main(string[] args)
        {

            /*CorrenteDeDescontos corrente = new CorrenteDeDescontos();

            Orcamento orcamento = new Orcamento(400.0);
            orcamento.AdicionaItem(new Item("CANETA", 250.0));
            orcamento.AdicionaItem(new Item("LAPIS", 220.0));
            orcamento.AdicionaItem(new Item("LAPIS", 220.0));
            orcamento.AdicionaItem(new Item("LAPIS", 220.0));
            orcamento.AdicionaItem(new Item("LAPIS", 220.0));

            double desconto = corrente.Calcula(orcamento);

            Console.WriteLine(desconto);*/

            /*ISS icpp = new ISS(new IHIT(new ICCC()));
            Orcamento orcamento = new Orcamento(500);
            orcamento.AdicionaItem(new Item("CANETA", 250.0));
            orcamento.AdicionaItem(new Item("LAPIS", 220.0));
 


            double desconto = icpp.Calcula(orcamento);
            Console.WriteLine(desconto);*/

            /*Orcamento orcamento = new Orcamento(300);
            orcamento.AplicaDescontoExtra();
            orcamento.Aprova();
            Console.WriteLine(orcamento.EstadoAtual);*/

            NotaFiscal nf = new NotaFiscal();
            nf.ComRazaoSocial("Teste");
            nf.ComCNPJ("12345");
            nf.comItem(new NotasFiscais.Item("Morango", 3.50));
            nf.ComEnvio(new EnviaEmail());
            nf.ComEnvio(new EnviaNFE());
            nf.ComEnvio(new EnviaSMS());

            NotaFiscal resultado = nf.Constroi();
            Console.WriteLine("---Razão Social: " +resultado.RazaoSocial+"---\n"+
                "---CNPJ: " + resultado.CNPJ + "---\n"
                + "Item: "+ resultado.Itens[0].Nome + " Valor: " + resultado.Itens[0].Valor + "\n"+
                "Total: "+resultado.TotalNota + "\n"+
                "Desconto Total: "+resultado.DescontoTotal);
        }
    }
}
