using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Editor_de_Texto
{
    public partial class FrmSalvar : Form
    {
        public FrmSalvar()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private string DA()
        {
            var caminho = lblDiretorio.Text + @"\" + lblNomeArquivo.Text + ".txt";
            return caminho;
        }
        public void Salvar()
        {
            if (File.Exists(DA()))
            {
                MessageBox.Show("O arquivo já existe!");
            }
            else if (Directory.Exists(lblDiretorio.Text))
            {
                MessageBox.Show("O arquivo já existe!");
            }
            else
            {
                File.WriteAllText(DA(), lblNomeArquivo.Text);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Salvar();
            Close();
        }
    }
}
