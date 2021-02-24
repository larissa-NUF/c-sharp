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
    public partial class FrmTC : Form
    {
        public FrmTC()
        {
            InitializeComponent();
        }

        private void FrmTC_Load(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab("TabPagamento");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab("TabDados");
        }
    }
}
