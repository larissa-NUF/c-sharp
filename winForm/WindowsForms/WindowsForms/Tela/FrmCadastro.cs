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
    public partial class FrmCadastro : Form
    {
        public FrmCadastro()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            var nome = txtNome.Text;
            try
            {
                int numero = int.Parse(txtNumero.Text);

                if (numero == 2)
                {
                    throw new ErroProposito("Erro proposital2");
                }
                numero += 100;

                MessageBox.Show("Olá " + nome + "\nValor:" + numero);
            }
            catch (ErroProposito errProposito)
            {
                MessageBox.Show("Valor inválido" + "0000000000" + errProposito.Message);
            }
            catch (FormatException errFormat)
            {
                MessageBox.Show("Valor inválido" + "Esse campo só aceita número" + errFormat.Message);
            }
            catch(Exception err)
            {
                MessageBox.Show("Valor inválido" + err.Message);
                txtNumero.Focus();
            }
            finally
            {
                MessageBox.Show("Exceções tratadas");
            }
        }

        private void txtCPF_Leave(object sender, EventArgs e)
        {
            if (txtCPF.MaskCompleted)
            {
                MessageBox.Show("OK.");
            }
            else
            {
                MessageBox.Show("Máscara incompleta");
            }
        }

        private void btnMostrarCPF_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txtCPF.Text);
        }
    }

    public class ErroProposito : Exception
    {
        public ErroProposito(string erro) : base(erro) { }
    }
}
