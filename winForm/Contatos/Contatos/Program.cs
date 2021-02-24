using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contatos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lista de contatos");

            var senha = 0000;
            var senhaD = int.Parse(Console.ReadLine());
            if (senhaD == senha)
            {
                Console.WriteLine("" +
                "\n1154456546564" +
                "\n54554654654" +
                "\n45645454557257" +
                "\n4534545545445");
            }
            else
            {
                Console.WriteLine("Senha incorreta");
            }

            

            Console.ReadLine();
        }
    }
}
