using Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tela;

namespace Funcoes
{
    class TelaClientes
    {
        public static void Chamar()
        {
            while (true)
            {
                string mensagem =
                "\nDigite uma das opções:" +
                "\n1 - Para cadastrar um cliente" +
                "\n2 - Para listar os clientes" +
                "\n0 - Para voltar";
                Console.WriteLine(mensagem);
                int valor = int.Parse(Console.ReadLine());
                Console.WriteLine("===================================================");

                if (valor == 0)
                {
                    break;
                }
                else if (valor == 1)
                {
                    Console.WriteLine("============================ Cadastrar cliente ===========================");
                    var cliente = new Cliente();
                    Console.WriteLine("Nome:");
                    cliente.Nome = Console.ReadLine();
                    Console.WriteLine("-----------------");
                    Console.WriteLine("Telefone:");
                    cliente.Telefone = Console.ReadLine();
                    Console.WriteLine("-----------------");
                    Console.WriteLine("CPF:");
                    cliente.CPF = Console.ReadLine();
                    Console.WriteLine("-----------------");
                    cliente.Gravar();
                    Console.WriteLine("=======================================================");
                }
                else if (valor == 2)
                {
                    Console.WriteLine("============================= Clientes ==========================");
                    var clientes = new Cliente().Ler();
                    foreach (Cliente c in clientes)
                    {
                        Console.WriteLine("Nome:" + c.Nome);
                        Console.WriteLine("Telefone:" + c.Telefone);
                        Console.WriteLine("CPF:" + c.CPF);
                        Console.WriteLine("--------------------------------------------------");
                    }
                }
            }

            //Ler arquivo base de dados com POO (Não terminado)

            //Cliente c2 = new Cliente { CPF = "09809809856" };

            

            
        }
    }
}
