using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class FrmPanel : Form
    {
        public FrmPanel()
        {
            InitializeComponent();
        }

        private void ckbCPF_CheckedChanged(object sender, EventArgs e)
        {
            lblTipo.Text = "CPF:";  
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            lblTipo.Text = "CNPJ:";
        }

        private void pnlCPF_Paint(object sender, PaintEventArgs e)
        {

        }

        
    }
}
