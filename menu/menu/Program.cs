
using Classes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tela;

namespace menu
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu.Criar();
        }            
    }
}
#region POO
/*
class Carro 
{
    public string Marca;

    private string local = "SP";
    public string Marca2 
    { 
        get 
        {
            return local;
        } 
        set
        {
            local = value;
        }
    }

}

Email.Insta.Destino = "loooooooooool";
Email.Insta.EnviarEmail();

var car = new Carro
{
    Marca = "fox",
    Marca2 = "fox2"

};

Console.WriteLine(car.Marca);
Console.WriteLine(car.Marca2);

Console.WriteLine("============================= Clientes ==========================");
var clientes = new Cliente().Ler();
foreach (Cliente c in clientes)
{
    Console.WriteLine("Nome:" + c.Nome);
    Console.WriteLine("Telefone:" + c.Telefone);
    Console.WriteLine("CPF:" + c.CPF);
    Console.WriteLine("--------------------------------------------------");
}

Console.WriteLine("============================= Cliente ==========================");
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
*/
#endregion
