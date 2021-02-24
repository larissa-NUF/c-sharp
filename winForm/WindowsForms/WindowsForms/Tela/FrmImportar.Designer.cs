
namespace WindowsForms
{
    partial class FrmImportar
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
            this.lblImportar = new System.Windows.Forms.Label();
            this.btnImportar = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.txtLogs = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblImportar
            // 
            this.lblImportar.AutoSize = true;
            this.lblImportar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImportar.Location = new System.Drawing.Point(225, 117);
            this.lblImportar.Name = "lblImportar";
            this.lblImportar.Size = new System.Drawing.Size(325, 20);
            this.lblImportar.TabIndex = 5;
            this.lblImportar.Text = "Clique em Importar para importar os arquivos";
            // 
            // btnImportar
            // 
            this.btnImportar.Location = new System.Drawing.Point(160, 336);
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.Size = new System.Drawing.Size(480, 47);
            this.btnImportar.TabIndex = 4;
            this.btnImportar.Text = "Importar";
            this.btnImportar.UseVisualStyleBackColor = true;
            this.btnImportar.Click += new System.EventHandler(this.btnImportar_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Enabled = false;
            this.progressBar1.Location = new System.Drawing.Point(160, 159);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(480, 69);
            this.progressBar1.TabIndex = 3;
            // 
            // txtLogs
            // 
            this.txtLogs.AcceptsReturn = true;
            this.txtLogs.Location = new System.Drawing.Point(160, 234);
            this.txtLogs.Multiline = true;
            this.txtLogs.Name = "txtLogs";
            this.txtLogs.ReadOnly = true;
            this.txtLogs.Size = new System.Drawing.Size(480, 74);
            this.txtLogs.TabIndex = 6;
            // 
            // FrmImportar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtLogs);
            this.Controls.Add(this.lblImportar);
            this.Controls.Add(this.btnImportar);
            this.Controls.Add(this.progressBar1);
            this.Name = "FrmImportar";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblImportar;
        private System.Windows.Forms.Button btnImportar;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox txtLogs;
    }
}