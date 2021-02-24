using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Email
    {
        private Email() { }

        private static Email instancia;
        public string From;
        public string Destino;
        public string Corpo;
        public string Titulo;

        public static Email Insta
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new Email();
                }

                return instancia;
            }
        }

        public void EnviarEmail()
        {
            Console.WriteLine("Enviando e-mail para: " + instancia.Destino);
        }
    }
}
