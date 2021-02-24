using Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tela;

namespace Funcoes
{
    class TelaUsuarios
    {
        public static int TipoP()
        {
            var tipo =;
            return tipo;
        }

        public static void Chamar()
        {

            string tipoPessoa = "0";
            if (Menu.opcao == 4)
            {
                tipoPessoa = "cliente";
            }
            else if (Menu.opcao == 5)
            {
                tipoPessoa = "usuario";
            }

            while (true)
            {
                string mensagem =
                "\nDigite uma das opções:" +
                "\n1 - Para cadastrar um usuario" +
                "\n2 - Para listar os usuarios" +
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
                    Console.WriteLine("============================ Cadastrar usuario ===========================");
                    var pessoa = new Usuario();
                    Console.WriteLine("Nome:");
                    pessoa.Nome = Console.ReadLine();
                    Console.WriteLine("-----------------");
                    Console.WriteLine("Telefone:");
                    pessoa.Telefone = Console.ReadLine();
                    Console.WriteLine("-----------------");
                    Console.WriteLine("CPF:");
                    pessoa.CPF = Console.ReadLine();
                    Console.WriteLine("-----------------");
                    pessoa.Gravar();
                    Console.WriteLine("=======================================================");
                }
                else if (valor == 2)
                {
                    Console.WriteLine("============================= usuarios ==========================");
                    var pessoa = new Usuario().Ler();
                    foreach (Usuario p in pessoa)
                    {
                        Console.WriteLine("Nome:" + p.Nome);
                        Console.WriteLine("Telefone:" + p.Telefone);
                        Console.WriteLine("CPF:" + p.CPF);
                        Console.WriteLine("--------------------------------------------------");
                    }
                }
            }
        }
    }
}
