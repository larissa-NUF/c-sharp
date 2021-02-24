
namespace Editor_de_Texto
{
    partial class FrmSalvar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSalvar));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNomeArquivo = new System.Windows.Forms.TextBox();
            this.lblDiretorio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(56, 175);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome do Arquivo:";
            // 
            // lblNomeArquivo
            // 
            this.lblNomeArquivo.Location = new System.Drawing.Point(127, 61);
            this.lblNomeArquivo.Name = "lblNomeArquivo";
            this.lblNomeArquivo.Size = new System.Drawing.Size(196, 20);
            this.lblNomeArquivo.TabIndex = 2;
            // 
            // lblDiretorio
            // 
            this.lblDiretorio.Location = new System.Drawing.Point(127, 101);
            this.lblDiretorio.Name = "lblDiretorio";
            this.lblDiretorio.Size = new System.Drawing.Size(196, 20);
            this.lblDiretorio.TabIndex = 4;
            this.lblDiretorio.Text = "C:\\exemplo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Diretório:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(248, 175);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FrmSalvar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(384, 236);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lblDiretorio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNomeArquivo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSalvar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editor de Texto - Salvar Arquivo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox lblNomeArquivo;
        private System.Windows.Forms.TextBox lblDiretorio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancelar;
    }
}