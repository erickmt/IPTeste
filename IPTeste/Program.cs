using System;

namespace IPTeste
{
    class Program
    {
        static void Main(string[] args)
        {
            Estudantes estudantes = ObterDados.ObterEstudantes();
            Impressora impressora = new Impressora();

            impressora.ImprimeEntidade(estudantes, impressora);

            Console.ReadKey();
        }
    }
}
