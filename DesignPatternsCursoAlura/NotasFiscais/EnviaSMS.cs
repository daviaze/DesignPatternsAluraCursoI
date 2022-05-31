using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsCursoAlura.NotasFiscais
{
    public class EnviaSMS : IExecuta
    {
        public void Executa()
        {
            Console.WriteLine("Envia SMS!");
        }
    }
}
