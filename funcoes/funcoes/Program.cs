using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace funcoes
{
    class Program2
    {
        static void main(string[] args)
        {
            Program.Tabuada(6);

            var pg = new Program();
            pg.exibir();


        }
    }
    
    class Program
    {
        public void exibir()
        {
            Console.WriteLine("hmmmmmmmmmmmmmm");
            Console.WriteLine("aldeão");
        }

        public static void Tabuada(int numero)
        {
            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine(numero + "x" + i + "=" + (numero * i));
            }
            
        }
        static void Main(string[] args)
        {

            Tabuada(5);        
            
            exibirPreco(10, "legal");
            exibirPreco(-5, "Larissa");

            int retornar1 = retornar();

            Console.WriteLine(retornar1);
            
            int[] vetor = new int[5]
            {
                1,
                2,
                3,
                4,
                5
            };

            Console.WriteLine(vetor[1]);

            

            Console.ReadLine();
        }

        static void exibirPreco(int preco, string tipo)
        {

            int precoAbs = Math.Abs(preco);

            Console.WriteLine(preco);
            Console.WriteLine(tipo + " nunes");

            int final = precoAbs + 2;
            Console.WriteLine("Valor final:" + final);

        }
        static int retornar()
        {
            int a1 = 1 + 2;
            return a1;
        }
    }
}
