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
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "Hmmmmmmmmmmmmm" + ((Estado)cboEstados.SelectedItem).Id;
        }

        private void btnAbrirNovaJanela_Click(object sender, EventArgs e)
        {
            var form1 = new FrmShow();
            form1.lblMensagem.Text = txtResultado.Text;
            form1.MdiParent = MDISingleton.InstSingleton();
            form1.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var menuIcon = new ContextMenu();
            menuIcon.MenuItems.Add(new MenuItem("Abrir Cadastro", abrirCadastro_Click));
            menuIcon.MenuItems.Add(new MenuItem("Sair", sairAplicativo_Click));
            notifyIcon1.ContextMenu = menuIcon;

            AtualizarDataHora();

            cboEstados.DataSource = Estado.ListaEstados();
            cboEstados.Text = "[Selecione]";

            /*foreach (Estado es in Estado.ListaEstados())
            {
                cboEstados.Items.Add(es);
            }*/

            //dataGridView.DataSource = Estado.ListaEstados();

            var data = from estado in Estado.ListaEstados()
                       select new
                       {
                           Sigla = estado.Nome,
                           Nome = estado.Nome2
                       };

            dataGridView.DataSource = data.ToList();
        }

        private void AtualizarDataHora()
        {
            lblDataHora.Text = "Data e Hora atual:" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            AtualizarDataHora();
        }

        private void notifyIcon1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cliquei no icon");
        }

        private void sairAplicativo_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblNotificacao_Click(object sender, EventArgs e)
        {
            notifyIcon1.ShowBalloonTip(10, "Notíficação", "Você foi notificado.", ToolTipIcon.None);
        }

        private void abrirCadastro_Click(object sender, EventArgs e)
        {
            var form = new FrmCadastro();
            form.MdiParent = MDISingleton.InstSingleton();
            form.Show();
        }
    }
}

#region dataGrid escolher colunas (modo difício)
/*dataGridView.ColumnCount = 2;
dataGridView.Columns[0].Name = "Sigla";
dataGridView.Columns[0].Name = "Nome";

var linhas = new List<string[]>();
foreach (Estado estado in Estado.ListaEstados())
{
    string[] linha1 = new string[] { estado.Nome, estado.Nome2 };
    linhas.Add(linha1);
}

foreach (string[] porLinha in linhas)
{
    dataGridView.Rows.Add(porLinha);
}*/
#endregion