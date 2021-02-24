using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public interface iPessoa
    {
        void Gravar();
        void setNome(string _iNome);
        void setTelefone(string _iTelefone);
        void setCPF(string _iCPF);
    }
}
