
namespace WindowsForms
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.btnAbrirNovaJanela = new System.Windows.Forms.Button();
            this.cboEstados = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDataHora = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opcoesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.lblNotificacao = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Clique em OK para exibir o texto";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(134, 236);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(151, 53);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(102, 169);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(210, 20);
            this.txtResultado.TabIndex = 2;
            // 
            // btnAbrirNovaJanela
            // 
            this.btnAbrirNovaJanela.Location = new System.Drawing.Point(134, 316);
            this.btnAbrirNovaJanela.Name = "btnAbrirNovaJanela";
            this.btnAbrirNovaJanela.Size = new System.Drawing.Size(151, 23);
            this.btnAbrirNovaJanela.TabIndex = 3;
            this.btnAbrirNovaJanela.Text = "Abrir nova janela";
            this.btnAbrirNovaJanela.UseVisualStyleBackColor = true;
            this.btnAbrirNovaJanela.Click += new System.EventHandler(this.btnAbrirNovaJanela_Click);
            // 
            // cboEstados
            // 
            this.cboEstados.FormattingEnabled = true;
            this.cboEstados.Items.AddRange(new object[] {
            "Sp",
            "RJ",
            "SC"});
            this.cboEstados.Location = new System.Drawing.Point(521, 104);
            this.cboEstados.Name = "cboEstados";
            this.cboEstados.Size = new System.Drawing.Size(121, 21);
            this.cboEstados.TabIndex = 4;
            this.cboEstados.Text = "Selecione";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(438, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Estados\r\n";
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(425, 208);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(240, 150);
            this.dataGridView.TabIndex = 6;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(435, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(220, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Dados da coleção de estados";
            // 
            // lblDataHora
            // 
            this.lblDataHora.AutoSize = true;
            this.lblDataHora.Location = new System.Drawing.Point(564, 476);
            this.lblDataHora.Name = "lblDataHora";
            this.lblDataHora.Size = new System.Drawing.Size(200, 13);
            this.lblDataHora.TabIndex = 8;
            this.lblDataHora.Text = "Data e Hora atual: 01/01/0000 00:00:00";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.opcoesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(776, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sairToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairAplicativo_Click);
            // 
            // opcoesToolStripMenuItem
            // 
            this.opcoesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem1});
            this.opcoesToolStripMenuItem.Name = "opcoesToolStripMenuItem";
            this.opcoesToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.opcoesToolStripMenuItem.Text = "Telas";
            // 
            // cadastroToolStripMenuItem1
            // 
            this.cadastroToolStripMenuItem1.Name = "cadastroToolStripMenuItem1";
            this.cadastroToolStripMenuItem1.Size = new System.Drawing.Size(121, 22);
            this.cadastroToolStripMenuItem1.Text = "Cadastro";
            this.cadastroToolStripMenuItem1.Click += new System.EventHandler(this.abrirCadastro_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Programa Form1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.Click += new System.EventHandler(this.notifyIcon1_Click);
            // 
            // lblNotificacao
            // 
            this.lblNotificacao.Location = new System.Drawing.Point(102, 401);
            this.lblNotificacao.Name = "lblNotificacao";
            this.lblNotificacao.Size = new System.Drawing.Size(210, 49);
            this.lblNotificacao.TabIndex = 10;
            this.lblNotificacao.Text = "Mandar notificação";
            this.lblNotificacao.UseVisualStyleBackColor = true;
            this.lblNotificacao.Click += new System.EventHandler(this.lblNotificacao_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 498);
            this.Controls.Add(this.lblNotificacao);
            this.Controls.Add(this.lblDataHora);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboEstados);
            this.Controls.Add(this.btnAbrirNovaJanela);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button btnAbrirNovaJanela;
        private System.Windows.Forms.ComboBox cboEstados;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDataHora;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.Button lblNotificacao;
        private System.Windows.Forms.ToolStripMenuItem opcoesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem1;
    }
}

