using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AulaExceptions
{
    class LeitorDeArquivos : IDisposable
    {
        public string Arquivo { get; }

        public LeitorDeArquivos(string arquivo)
        {
            Arquivo = arquivo;

            throw new FileNotFoundException();

            Console.WriteLine("Abrindo arquivo: " + arquivo);
        }

        public string LerProximaLinha()
        {
            
            Console.WriteLine("Lendo linha .  .  .");

            throw new IOException();

            //return "Linha do arquivo";
        }

        public void Fechar()
        {
            Console.WriteLine("Fechando arquivo.");
        }

        public void Dispose() // responsabilidade de liberar os recursos
        {
            Console.WriteLine("Fechando o arquivo.");
        }
    }
}
