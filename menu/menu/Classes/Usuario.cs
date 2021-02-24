using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Usuario : Base
    {
        public Usuario(string _nome, string _telefone, string _CPF)
        {
            this.CPF = _CPF;
            this.Nome = _nome;
            this.Telefone = _telefone;
        }

        public Usuario() { }
    }
}
