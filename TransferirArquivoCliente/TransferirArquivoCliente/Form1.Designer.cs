
namespace TransferirArquivoCliente
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.numUpPorta = new System.Windows.Forms.NumericUpDown();
            this.linkLabelArquivo = new System.Windows.Forms.LinkLabel();
            this.lblStatus = new System.Windows.Forms.Label();
            this.brnEnviarArquivo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numUpPorta)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(116, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(424, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cliente Para Compartilhar Arquivo";
            // 
            // txtIP
            // 
            this.txtIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIP.Location = new System.Drawing.Point(13, 71);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(215, 31);
            this.txtIP.TabIndex = 1;
            this.txtIP.Text = "127.0.0.1";
            this.txtIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numUpPorta
            // 
            this.numUpPorta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numUpPorta.Location = new System.Drawing.Point(286, 71);
            this.numUpPorta.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numUpPorta.Name = "numUpPorta";
            this.numUpPorta.Size = new System.Drawing.Size(120, 31);
            this.numUpPorta.TabIndex = 2;
            this.numUpPorta.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // linkLabelArquivo
            // 
            this.linkLabelArquivo.AutoSize = true;
            this.linkLabelArquivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelArquivo.Location = new System.Drawing.Point(13, 130);
            this.linkLabelArquivo.Name = "linkLabelArquivo";
            this.linkLabelArquivo.Size = new System.Drawing.Size(312, 24);
            this.linkLabelArquivo.TabIndex = 3;
            this.linkLabelArquivo.TabStop = true;
            this.linkLabelArquivo.Text = "Clique para selecionar um arquivo...";
            this.linkLabelArquivo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelArquivo_LinkClicked);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblStatus.Location = new System.Drawing.Point(270, 246);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(98, 31);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.Text = "Status";
            // 
            // brnEnviarArquivo
            // 
            this.brnEnviarArquivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brnEnviarArquivo.Location = new System.Drawing.Point(17, 170);
            this.brnEnviarArquivo.Name = "brnEnviarArquivo";
            this.brnEnviarArquivo.Size = new System.Drawing.Size(221, 40);
            this.brnEnviarArquivo.TabIndex = 5;
            this.brnEnviarArquivo.Text = "Enviar Arquivo";
            this.brnEnviarArquivo.UseVisualStyleBackColor = true;
            this.brnEnviarArquivo.Click += new System.EventHandler(this.brnEnviarArquivo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 355);
            this.Controls.Add(this.brnEnviarArquivo);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.linkLabelArquivo);
            this.Controls.Add(this.numUpPorta);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numUpPorta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.NumericUpDown numUpPorta;
        private System.Windows.Forms.LinkLabel linkLabelArquivo;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button brnEnviarArquivo;
    }
}

