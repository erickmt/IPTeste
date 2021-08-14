using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPTeste
{
    [JsonObject("student")]
    public class Estudante : IEntidade
    {
        [JsonProperty("name")]
        public string Nome { get; set; }
        
        [JsonProperty("course")]
        public string Curso { get; set; }
        
        [JsonProperty("scholarshipHolder")]
        public bool Bolsista { get; set; }

        [JsonProperty("integratedProjectAverageScore")]
        public string MediaDasNotas { get; set; }


        public void Imprime(Impressora impressora)
        {
            string estudate = string.Format("\t 'Nome: {0} | Curso: {1} | Media das notas do Projeto Integrado: {2}'{3}",
                Nome, Curso, MediaDasNotas, ultimo ? "" : ",");

            impressora.ImprimeTexto(estudate);
        }

        public void Ultimo()
        {
            ultimo = true;
        }

        private bool ultimo;

    }

}
