using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcoes
{
    class Tabuada
    {
        public static void Calcular()
        {
            Console.WriteLine("===================== Tabuada =====================");
            Console.WriteLine("Digite um número:");
            int numeroTabuada = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i + "x" + numeroTabuada +
                    "=" + (i * numeroTabuada));
            }

            Console.WriteLine("===================================================");
        }
    }
}
