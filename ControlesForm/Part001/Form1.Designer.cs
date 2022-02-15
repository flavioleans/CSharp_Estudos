
namespace Part001
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
            this.lblTexto = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTexto
            // 
            this.lblTexto.AutoEllipsis = true;
            this.lblTexto.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblTexto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTexto.Location = new System.Drawing.Point(12, 14);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(248, 98);
            this.lblTexto.TabIndex = 0;
            this.lblTexto.Text = "CURSO C# COMPLETO E PROFISSIONAL";
            this.lblTexto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTexto.Click += new System.EventHandler(this.lblTexto_Click);
            this.lblTexto.MouseEnter += new System.EventHandler(this.lblTexto_MouseEnter);
            this.lblTexto.MouseLeave += new System.EventHandler(this.lblTexto_MouseLeave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 392);
            this.Controls.Add(this.lblTexto);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTexto;
    }
}

