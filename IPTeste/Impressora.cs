using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPTeste
{
    public class Impressora
    {
        public void ImprimeTexto(string texto)
        {
            Console.WriteLine(texto);
        }

        public void ImprimeEntidade(IEntidade entidade, Impressora impressora)
        {
            entidade.Imprime(impressora);
        }

    }
}
