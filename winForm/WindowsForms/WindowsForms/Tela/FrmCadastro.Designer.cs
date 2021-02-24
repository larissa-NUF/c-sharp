
namespace WindowsForms
{
    partial class FrmCadastro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastro));
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.txtCPF = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.MaskedTextBox();
            this.txtNome = new System.Windows.Forms.MaskedTextBox();
            this.btnMostrarCPF = new System.Windows.Forms.Button();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.salvarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarTudoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripDropDownButton3 = new System.Windows.Forms.ToolStripDropDownButton();
            this.testeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teste2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teste3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(151, 252);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(89, 26);
            this.btnCalcular.TabIndex = 0;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(81, 144);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome:";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(81, 179);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(47, 13);
            this.lblTelefone.TabIndex = 3;
            this.lblTelefone.Text = "Número:";
            // 
            // txtCPF
            // 
            this.txtCPF.BeepOnError = true;
            this.txtCPF.Location = new System.Drawing.Point(151, 108);
            this.txtCPF.Mask = "000.000.000-00";
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(238, 20);
            this.txtCPF.TabIndex = 5;
            this.txtCPF.Leave += new System.EventHandler(this.txtCPF_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "CPF:";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(151, 176);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(238, 20);
            this.txtNumero.TabIndex = 7;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(151, 141);
            this.txtNome.Mask = ">LLLL";
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(238, 20);
            this.txtNome.TabIndex = 8;
            // 
            // btnMostrarCPF
            // 
            this.btnMostrarCPF.Location = new System.Drawing.Point(300, 252);
            this.btnMostrarCPF.Name = "btnMostrarCPF";
            this.btnMostrarCPF.Size = new System.Drawing.Size(89, 26);
            this.btnMostrarCPF.TabIndex = 9;
            this.btnMostrarCPF.Text = "Mostrar CPF";
            this.btnMostrarCPF.UseVisualStyleBackColor = true;
            this.btnMostrarCPF.Click += new System.EventHandler(this.btnMostrarCPF_Click);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(151, 211);
            this.maskedTextBox1.Mask = "$#9,99";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(238, 20);
            this.maskedTextBox1.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Valor:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox1,
            this.toolStripButton1,
            this.toolStripLabel1,
            this.toolStripSeparator1,
            this.toolStripDropDownButton1,
            this.toolStripComboBox1,
            this.toolStripSplitButton1,
            this.toolStripDropDownButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(786, 25);
            this.toolStrip1.TabIndex = 12;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.AcceptsTab = true;
            this.toolStripTextBox1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripTextBox1.BackColor = System.Drawing.SystemColors.Window;
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(200, 25);
            this.toolStripTextBox1.Text = "Digite para pesquisar";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(86, 22);
            this.toolStripLabel1.Text = "toolStripLabel1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salvarToolStripMenuItem,
            this.salvarTudoToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(29, 22);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // salvarToolStripMenuItem
            // 
            this.salvarToolStripMenuItem.Name = "salvarToolStripMenuItem";
            this.salvarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salvarToolStripMenuItem.Text = "Salvar";
            // 
            // salvarTudoToolStripMenuItem
            // 
            this.salvarTudoToolStripMenuItem.Name = "salvarTudoToolStripMenuItem";
            this.salvarTudoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salvarTudoToolStripMenuItem.Text = "Salvar Tudo";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Items.AddRange(new object[] {
            "Teste 1",
            "teste 2"});
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 25);
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(32, 22);
            this.toolStripSplitButton1.Text = "toolStripSplitButton1";
            // 
            // toolStripDropDownButton2
            // 
            this.toolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton2.Image")));
            this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            this.toolStripDropDownButton2.Size = new System.Drawing.Size(29, 22);
            this.toolStripDropDownButton2.Text = "toolStripDropDownButton2";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripProgressBar1,
            this.toolStripDropDownButton3});
            this.statusStrip1.Location = new System.Drawing.Point(0, 351);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(786, 22);
            this.statusStrip1.TabIndex = 13;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(43, 17);
            this.toolStripStatusLabel1.Text = "Pronto";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            // 
            // toolStripDropDownButton3
            // 
            this.toolStripDropDownButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testeToolStripMenuItem,
            this.teste3ToolStripMenuItem,
            this.teste2ToolStripMenuItem});
            this.toolStripDropDownButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton3.Image")));
            this.toolStripDropDownButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton3.Name = "toolStripDropDownButton3";
            this.toolStripDropDownButton3.Size = new System.Drawing.Size(29, 20);
            this.toolStripDropDownButton3.Text = "toolStripDropDownButton3";
            // 
            // testeToolStripMenuItem
            // 
            this.testeToolStripMenuItem.Name = "testeToolStripMenuItem";
            this.testeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.testeToolStripMenuItem.Text = "teste";
            // 
            // teste2ToolStripMenuItem
            // 
            this.teste2ToolStripMenuItem.Name = "teste2ToolStripMenuItem";
            this.teste2ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.teste2ToolStripMenuItem.Text = "teste2";
            // 
            // teste3ToolStripMenuItem
            // 
            this.teste3ToolStripMenuItem.Name = "teste3ToolStripMenuItem";
            this.teste3ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.teste3ToolStripMenuItem.Text = "teste3";
            // 
            // FrmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 373);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnMostrarCPF);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.btnCalcular);
            this.Name = "FrmCadastro";
            this.Text = "Form2";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.MaskedTextBox txtCPF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtNumero;
        private System.Windows.Forms.MaskedTextBox txtNome;
        private System.Windows.Forms.Button btnMostrarCPF;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem salvarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvarTudoToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton3;
        private System.Windows.Forms.ToolStripMenuItem testeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teste3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teste2ToolStripMenuItem;
    }
}