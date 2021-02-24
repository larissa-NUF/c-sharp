
namespace WindowsForms
{
    partial class FrmTC
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
            this.tabPagamento = new System.Windows.Forms.TabPage();
            this.tabDados = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.lblCNPJ = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ckbCNPJ = new System.Windows.Forms.CheckBox();
            this.ckbCPF = new System.Windows.Forms.CheckBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tabPagamento.SuspendLayout();
            this.tabDados.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPagamento
            // 
            this.tabPagamento.Controls.Add(this.btnBack);
            this.tabPagamento.Controls.Add(this.ckbCNPJ);
            this.tabPagamento.Controls.Add(this.ckbCPF);
            this.tabPagamento.Controls.Add(this.textBox4);
            this.tabPagamento.Controls.Add(this.label5);
            this.tabPagamento.Controls.Add(this.textBox5);
            this.tabPagamento.Controls.Add(this.label6);
            this.tabPagamento.Controls.Add(this.textBox1);
            this.tabPagamento.Controls.Add(this.label1);
            this.tabPagamento.Controls.Add(this.button2);
            this.tabPagamento.Controls.Add(this.textBox2);
            this.tabPagamento.Controls.Add(this.label2);
            this.tabPagamento.Location = new System.Drawing.Point(4, 22);
            this.tabPagamento.Name = "tabPagamento";
            this.tabPagamento.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagamento.Size = new System.Drawing.Size(768, 400);
            this.tabPagamento.TabIndex = 1;
            this.tabPagamento.Text = "Pagamento";
            this.tabPagamento.UseVisualStyleBackColor = true;
            // 
            // tabDados
            // 
            this.tabDados.Controls.Add(this.button3);
            this.tabDados.Controls.Add(this.lblCNPJ);
            this.tabDados.Controls.Add(this.label3);
            this.tabDados.Controls.Add(this.button1);
            this.tabDados.Controls.Add(this.textBox3);
            this.tabDados.Controls.Add(this.label4);
            this.tabDados.Location = new System.Drawing.Point(4, 22);
            this.tabDados.Name = "tabDados";
            this.tabDados.Padding = new System.Windows.Forms.Padding(3);
            this.tabDados.Size = new System.Drawing.Size(768, 400);
            this.tabDados.TabIndex = 0;
            this.tabDados.Text = "Dados Básicos";
            this.tabDados.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabDados);
            this.tabControl1.Controls.Add(this.tabPagamento);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 426);
            this.tabControl1.TabIndex = 0;
            // 
            // lblCNPJ
            // 
            this.lblCNPJ.Location = new System.Drawing.Point(296, 180);
            this.lblCNPJ.Name = "lblCNPJ";
            this.lblCNPJ.Size = new System.Drawing.Size(217, 20);
            this.lblCNPJ.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(256, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "CNPJ:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(364, 236);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Cadastrar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(296, 142);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(217, 20);
            this.textBox3.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(255, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nome:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(292, 240);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(217, 20);
            this.textBox1.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(252, 243);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "CNPJ:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(360, 296);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Cadastrar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(292, 202);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(217, 20);
            this.textBox2.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(251, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nome:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(292, 167);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(217, 20);
            this.textBox4.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(252, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "CNPJ:";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(292, 129);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(217, 20);
            this.textBox5.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(251, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Nome:";
            // 
            // ckbCNPJ
            // 
            this.ckbCNPJ.AutoSize = true;
            this.ckbCNPJ.Location = new System.Drawing.Point(407, 76);
            this.ckbCNPJ.Name = "ckbCNPJ";
            this.ckbCNPJ.Size = new System.Drawing.Size(102, 17);
            this.ckbCNPJ.TabIndex = 20;
            this.ckbCNPJ.Text = "Pessoa Jurídica";
            this.ckbCNPJ.UseVisualStyleBackColor = true;
            // 
            // ckbCPF
            // 
            this.ckbCPF.AutoSize = true;
            this.ckbCPF.Location = new System.Drawing.Point(255, 76);
            this.ckbCPF.Name = "ckbCPF";
            this.ckbCPF.Size = new System.Drawing.Size(93, 17);
            this.ckbCPF.TabIndex = 19;
            this.ckbCPF.Text = "Pessoa Física";
            this.ckbCPF.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(603, 371);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 21;
            this.btnBack.Text = "Voltar";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(687, 371);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 22;
            this.button3.Text = "Próximo";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // FrmTC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmTC";
            this.Text = "FrmCad";
            this.tabPagamento.ResumeLayout(false);
            this.tabPagamento.PerformLayout();
            this.tabDados.ResumeLayout(false);
            this.tabDados.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPagamento;
        private System.Windows.Forms.TabPage tabDados;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lblCNPJ;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox ckbCNPJ;
        private System.Windows.Forms.CheckBox ckbCPF;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button button3;
    }
}