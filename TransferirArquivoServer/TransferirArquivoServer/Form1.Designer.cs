
namespace TransferirArquivoServer
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.tbxIP = new System.Windows.Forms.TextBox();
            this.numUpPorta = new System.Windows.Forms.NumericUpDown();
            this.btnConexao = new System.Windows.Forms.Button();
            this.btnPararConexao = new System.Windows.Forms.Button();
            this.linkLabelPasta = new System.Windows.Forms.LinkLabel();
            this.listBoxLog = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.numUpPorta)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(22, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(524, 37);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Servidor Para Compartilhar Arquivo";
            // 
            // tbxIP
            // 
            this.tbxIP.Location = new System.Drawing.Point(29, 66);
            this.tbxIP.Multiline = true;
            this.tbxIP.Name = "tbxIP";
            this.tbxIP.Size = new System.Drawing.Size(244, 20);
            this.tbxIP.TabIndex = 1;
            this.tbxIP.Text = "127.0.0.1";
            // 
            // numUpPorta
            // 
            this.numUpPorta.Location = new System.Drawing.Point(303, 66);
            this.numUpPorta.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numUpPorta.Name = "numUpPorta";
            this.numUpPorta.Size = new System.Drawing.Size(90, 20);
            this.numUpPorta.TabIndex = 2;
            this.numUpPorta.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // btnConexao
            // 
            this.btnConexao.Location = new System.Drawing.Point(29, 126);
            this.btnConexao.Name = "btnConexao";
            this.btnConexao.Size = new System.Drawing.Size(169, 39);
            this.btnConexao.TabIndex = 3;
            this.btnConexao.Text = "Estabelecer Conexão";
            this.btnConexao.UseVisualStyleBackColor = true;
            this.btnConexao.Click += new System.EventHandler(this.btnConexao_Click);
            // 
            // btnPararConexao
            // 
            this.btnPararConexao.Location = new System.Drawing.Point(224, 126);
            this.btnPararConexao.Name = "btnPararConexao";
            this.btnPararConexao.Size = new System.Drawing.Size(169, 39);
            this.btnPararConexao.TabIndex = 4;
            this.btnPararConexao.Text = "Parar Conexão";
            this.btnPararConexao.UseVisualStyleBackColor = true;
            this.btnPararConexao.Click += new System.EventHandler(this.btnPararConexao_Click);
            // 
            // linkLabelPasta
            // 
            this.linkLabelPasta.AutoSize = true;
            this.linkLabelPasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelPasta.Location = new System.Drawing.Point(26, 198);
            this.linkLabelPasta.Name = "linkLabelPasta";
            this.linkLabelPasta.Size = new System.Drawing.Size(322, 25);
            this.linkLabelPasta.TabIndex = 5;
            this.linkLabelPasta.TabStop = true;
            this.linkLabelPasta.Text = "Clique para selecionar a pasta...";
            this.linkLabelPasta.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelPasta_LinkClicked);
            // 
            // listBoxLog
            // 
            this.listBoxLog.FormattingEnabled = true;
            this.listBoxLog.Location = new System.Drawing.Point(29, 237);
            this.listBoxLog.Name = "listBoxLog";
            this.listBoxLog.Size = new System.Drawing.Size(551, 173);
            this.listBoxLog.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 429);
            this.Controls.Add(this.listBoxLog);
            this.Controls.Add(this.linkLabelPasta);
            this.Controls.Add(this.btnPararConexao);
            this.Controls.Add(this.btnConexao);
            this.Controls.Add(this.numUpPorta);
            this.Controls.Add(this.tbxIP);
            this.Controls.Add(this.lblTitulo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numUpPorta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox tbxIP;
        private System.Windows.Forms.NumericUpDown numUpPorta;
        private System.Windows.Forms.Button btnConexao;
        private System.Windows.Forms.Button btnPararConexao;
        private System.Windows.Forms.LinkLabel linkLabelPasta;
        private System.Windows.Forms.ListBox listBoxLog;
    }
}

