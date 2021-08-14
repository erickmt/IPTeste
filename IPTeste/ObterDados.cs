using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPTeste
{
    static class ObterDados
    {
        public static Estudantes ObterEstudantes()
        {
            try
            {
                string textoEstudantes = LerArquivo.TextoDoArquivo("students.json");
                return JsonConvert.DeserializeObject<Estudantes>(textoEstudantes);
            }
            catch (Exception ex)
            {
                throw new Exception(string.Format("Erro ao converter extudantes: {0}", ex.Message));
            }
        }
    }
}
