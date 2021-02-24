using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace idade
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite sua idade:");
            int idade = int.Parse(Console.ReadLine());
                
            if (idade >= 0 && idade <= 11)
            {

                Console.WriteLine("Você é uma criança.");

            }else if (idade >=12 && idade<= 18)
            {

                Console.WriteLine("Você é uma adolescente.");

            }else if (idade >= 19 && idade <= 50)
            {
                Console.WriteLine("Você é uma adulto.");
            }
            else
            {
                Console.WriteLine("Você é uma idoso.");
            }
            


            Console.ReadLine();
        }
    }
}
