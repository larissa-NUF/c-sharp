using System;
using System.IO;

namespace recursiva
{
    class Program
    {
        public const int SAIDA = 0;
        static void Main(string[] args)
        {
            LerArquivo(1);
            LerArquivo2(2);

            while (true)
            {
                Console.WriteLine("Digite 0 para sair");
                int valor = int.Parse(Console.ReadLine());
                if (valor == SAIDA)
                {
                    break;
                }
            }

            Console.ReadLine();
        }
        private static void LerArquivo(int numeroArquivo)
        {
            string caminho = @"C:\arquivos\a"+ numeroArquivo + ".txt";
            if (File.Exists(caminho))
            {
                var texto = File.ReadAllText(caminho);

                Console.WriteLine(texto);
            }

            string caminhoSeguinte = @"C:\arquivos\a" + (numeroArquivo + 1) + ".txt";
            if (File.Exists(caminhoSeguinte))
            {
                LerArquivo(numeroArquivo + 1);
            }
        }

        private static void LerArquivo2(int numeroArquivo)
        {
            string caminho = @"C:\arquivos\a" + numeroArquivo + ".txt";
            if (File.Exists(caminho))

                using (StreamReader arquivo = File.OpenText(caminho))
            {
                string linha;
                while ((linha = arquivo.ReadLine()) != null)
                {
                    Console.WriteLine(linha);
                }

            }

            string caminhoSeguinte = @"C:\arquivos\a" + (numeroArquivo + 1) + ".txt";
            if (File.Exists(caminhoSeguinte))
            {
                LerArquivo(numeroArquivo + 1);
            }
        }
    }
}
