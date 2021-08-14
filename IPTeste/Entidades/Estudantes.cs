using System;
using System.Collections.Generic;

namespace IPTeste
{
    public class Estudantes : IEntidade
    {
        public List<Estudante> students { get; set; }

        public void Imprime(Impressora impressora)
        {
            impressora.ImprimeTexto("[");

            foreach (var student in students)
            {
                if (students.Count == (students.IndexOf(student) + 1))
                    student.Ultimo();
                student.Imprime(impressora);
            }
            impressora.ImprimeTexto("]");
        }
    }
}
