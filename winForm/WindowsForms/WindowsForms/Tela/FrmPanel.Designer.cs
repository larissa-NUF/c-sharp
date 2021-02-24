
namespace WindowsForms
{
    partial class FrmPanel
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
            this.pnlCPF = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMC = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pnlCPF.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCPF
            // 
            this.pnlCPF.Controls.Add(this.textBox2);
            this.pnlCPF.Controls.Add(this.lblTipo);
            this.pnlCPF.Controls.Add(this.btnCadastrar);
            this.pnlCPF.Controls.Add(this.txtNome);
            this.pnlCPF.Controls.Add(this.label1);
            this.pnlCPF.Location = new System.Drawing.Point(12, 107);
            this.pnlCPF.Name = "pnlCPF";
            this.pnlCPF.Size = new System.Drawing.Size(366, 246);
            this.pnlCPF.TabIndex = 0;
            this.pnlCPF.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCPF_Paint);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(80, 123);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(217, 20);
            this.textBox2.TabIndex = 5;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(47, 126);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(30, 13);
            this.lblTipo.TabIndex = 3;
            this.lblTipo.Text = "CPF:";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(148, 179);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrar.TabIndex = 2;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(80, 85);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(217, 20);
            this.txtNome.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // btnMC
            // 
            this.btnMC.Location = new System.Drawing.Point(534, 388);
            this.btnMC.Name = "btnMC";
            this.btnMC.Size = new System.Drawing.Size(133, 23);
            this.btnMC.TabIndex = 6;
            this.btnMC.Text = "Mostrar Cadastro";
            this.btnMC.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(8, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(85, 17);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(170, 19);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(85, 17);
            this.radioButton2.TabIndex = 3;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(54, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(304, 47);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // FrmPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnMC);
            this.Controls.Add(this.pnlCPF);
            this.Name = "FrmPanel";
            this.Text = "FrmCad";
            this.pnlCPF.ResumeLayout(false);
            this.pnlCPF.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCPF;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMC;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}