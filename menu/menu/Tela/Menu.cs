using Calculo;
using Diretorios;
using Funcoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tela
{
    class Menu
    {
        public const int SAIR = 0;
        public const int LER_ARQUIVOS = 1;
        public const int TABUADA = 2;
        public const int MEDIA_ALUNOS = 3;
        public const int CADASTRAR_CLIENTES = 4;
        public const int CADASTRAR_USUARIOS = 5;
        public const int CADASTRAR_FORNECEDORES = 6;

        public static void Criar()
        {
            while (true)
            {
                string mensagem =
                "\n Aplicação Console" +
                "\n" +
                "\n Digite uma das opções:" +
                "\n     1 - Para ler arquivos" +
                "\n     2 - Para executar a tabuada" +
                "\n     3 - Calcular a média dos alunos" +
                "\n     4 - Cadastro de clientes" +
                "\n     5 - Cadastro de usuários" +
                "\n     6 - Cadastro de fornecedores" +
                "\n     0 - Para sair do programa";
                Console.WriteLine(mensagem);
                int opcao = int.Parse(Console.ReadLine());
                Console.WriteLine("===================================================");

                if (opcao == 0)
                {
                    break;
                }
                else if (opcao == 1)
                {
                    Arquivos.Ler();
                }
                else if (opcao == 2)
                {
                    Tabuada.Calcular();
                }
                else if (opcao == 3)
                {
                    Media.Alunos();
                }
                else if (opcao == 4)
                {
                    TelaClientes.Chamar();
                }
                else if (opcao == 5)
                {
                    TelaUsuarios.Chamar();
                }
                else if (opcao == 6)
                {
                    TelaUsuarios.Chamar();
                }
                else
                {
                    Console.WriteLine("Opção inválida");
                    Console.WriteLine("===================================================");
                }
            }
        }
    }
}
