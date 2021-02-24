using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
     public abstract class Base : iPessoa
    {
        public Base(string _nome, string _telefone, string _CPF)
        {
            this.CPF = _CPF;
            this.Nome = _nome;
            this.Telefone = _telefone;
        }
        public Base() { }

        public string Nome;
        public string Telefone;
        public string CPF;

        public void setNome(string _iNome) { this.Nome = _iNome; }
        public void setTelefone(string _iTelefone) { this.Telefone = _iTelefone; }
        public void setCPF(string _iCPF) { this.CPF = _iCPF; }

        private string DiretorioComArquivo()
        {
            return ConfigurationManager.AppSettings["Caminho"] + this.GetType().Name + ".txt";
        }

        public List<Base> Ler()
        {
            var baseLista = new List<Base>();

            if(File.Exists(DiretorioComArquivo()))
            {
                string linha;
                int i = 0;

                StreamReader arquivo = new StreamReader(DiretorioComArquivo());
                while ((linha = arquivo.ReadLine()) != null)
                {
                    i++;
                    if (i == 1) continue;
                    var baseLinha = linha.Split(';');

                    var b = (Base)Activator.CreateInstance(this.GetType());
                    b.setNome(baseLinha[0]);
                    b.setTelefone(baseLinha[1]);
                    b.setCPF (baseLinha[2]);
                    
                    
                    baseLista.Add(b);
                }
                arquivo.Close();

            }
            else
            {
                Console.WriteLine("Arquivo não encontrado para registro");
            }

            return baseLista;
        }

        public virtual void Gravar()
        {

            var dados = this.Ler();
            dados.Add(this);

            if (File.Exists(DiretorioComArquivo()))
            {
                string conteudo = "nome; telefone; cpf;\n";
                foreach (Base c in dados)
                {
                    conteudo += c.Nome + ";" + c.Telefone + ";" + c.CPF + ";\n";
                }

                File.WriteAllText(DiretorioComArquivo(), conteudo);
                

            }
            else
            {
                Console.WriteLine("Arquivo não encontrado");
            }
        }
    }

}
