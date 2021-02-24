using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms
{
    public class Estado
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Nome2 { get; set; }

        public override string ToString()
        {
            return this.Nome;
        }

        public static List<Estado> ListaEstados()
        {
            var lista = new List<Estado>();
            var estados = new Estado();
            estados.Id = 1;
            estados.Nome = "SP";
            estados.Nome2 = "São Paulo";
            lista.Add(estados);

            var estados1 = new Estado();
            estados1.Id = 2;
            estados1.Nome = "RJ";
            estados1.Nome2 = "Rio de Janeiro";
            lista.Add(estados1);

            return lista;
        }
    }
}
