using System;
using System.IO;

namespace IPTeste
{
    public static class LerArquivo
    {
        public static string TextoDoArquivo(string nomeArquivo)
        {
            try
            {
                var diretorioAtual = Environment.CurrentDirectory;
                return File.ReadAllText(string.Format("{0}..\\..\\..\\{1}", diretorioAtual, nomeArquivo));
            }
            catch (Exception ex)
            {
                throw new Exception(string.Format("Erro ao ler o arquivo {0} : {1}", nomeArquivo, ex.Message));
            }
        }
    }
}
