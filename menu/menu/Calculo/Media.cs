using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculo
{
    class Media
    {
        public static void Alunos()
        {
            Console.WriteLine("Digite o nome do aluno:");
            string nomeAluno = Console.ReadLine();
            int numeroNotas = 3;
            Console.WriteLine("Digite as " + numeroNotas + " notas:");
            List<float> notas = new List<float>();
            float totalNota = 0;

            for (int i = 1; i <= numeroNotas; i++)
            {
                float nota = float.Parse(Console.ReadLine());
                notas.Add(nota);
                totalNota += nota;
            }

            float media = (totalNota / notas.Count);
            Console.WriteLine("------------------------------");
            Console.WriteLine("Nome do alunos:" + nomeAluno);
            Console.WriteLine("Média do alunos:" + media);
            Console.WriteLine("------------------------------");

            Console.WriteLine("===================================================");
        }
    }
}
