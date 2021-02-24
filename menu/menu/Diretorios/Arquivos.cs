using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diretorios
{
    class Arquivos
    {
        private static string CaminhoArquivos()
        {
            return ConfigurationManager.AppSettings["caminho_arquivos"];
        }
        public static void Ler()
        {
            Console.WriteLine("===================== Ler Arquivos =====================");
            Console.WriteLine("Caminho do arquivo: " + CaminhoArquivos());
            Console.WriteLine("Digite o nome do arquivo:");
            string caminho = CaminhoArquivos() + Console.ReadLine();
            
            if (File.Exists(caminho))
            {
                Console.WriteLine("===================================================");
                Console.WriteLine("Lendo" + caminho);
                Console.WriteLine("===================================================");
                string texto = File.ReadAllText(caminho);
                Console.WriteLine(texto);
            }
            else
            {
                Console.WriteLine("Caminho invalido");
            }

            Console.WriteLine("===================================================");

        }
    }
}
