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

namespace WindowsForms
{
    public partial class FrmImportar : Form
    {
        private string[] lines;
        public FrmImportar()
        {
            InitializeComponent();
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            StreamReader file = new StreamReader(@"c:\arquivos\base.txt");
            lines = file.ReadToEnd().Split("\n".ToArray());
            file.Close();
            progressBar1.Maximum = lines.Length;
            progressBar1.Minimum = 0;
            for(var i = 1; i <= lines.Length; i++)
            {
                progressBar1.Value = i++;

                /* Salvar arquivo
                var user = new UserControl();
                user.nome = lines;
                user.save();*/
                
            }
            if (progressBar1.Value == lines.Length)
            {
                txtLogs.Text = "OK";
            }
        }
    }
}
