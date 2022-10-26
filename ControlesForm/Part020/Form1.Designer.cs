
namespace Part020
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
            this.Browser = new System.Windows.Forms.WebBrowser();
            this.button1 = new System.Windows.Forms.Button();
            this.textUrl = new System.Windows.Forms.TextBox();
            this.buttonVoltar = new System.Windows.Forms.Button();
            this.buttonAvancar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Browser
            // 
            this.Browser.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Browser.Location = new System.Drawing.Point(0, 102);
            this.Browser.MinimumSize = new System.Drawing.Size(20, 20);
            this.Browser.Name = "Browser";
            this.Browser.Size = new System.Drawing.Size(594, 327);
            this.Browser.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(493, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 42);
            this.button1.TabIndex = 1;
            this.button1.Text = "Go";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textUrl
            // 
            this.textUrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textUrl.Location = new System.Drawing.Point(198, 67);
            this.textUrl.Name = "textUrl";
            this.textUrl.Size = new System.Drawing.Size(289, 29);
            this.textUrl.TabIndex = 2;
            // 
            // buttonVoltar
            // 
            this.buttonVoltar.Location = new System.Drawing.Point(13, 72);
            this.buttonVoltar.Name = "buttonVoltar";
            this.buttonVoltar.Size = new System.Drawing.Size(75, 23);
            this.buttonVoltar.TabIndex = 3;
            this.buttonVoltar.Text = "<";
            this.buttonVoltar.UseVisualStyleBackColor = true;
            this.buttonVoltar.Click += new System.EventHandler(this.buttonVoltar_Click);
            // 
            // buttonAvancar
            // 
            this.buttonAvancar.Location = new System.Drawing.Point(94, 73);
            this.buttonAvancar.Name = "buttonAvancar";
            this.buttonAvancar.Size = new System.Drawing.Size(75, 23);
            this.buttonAvancar.TabIndex = 4;
            this.buttonAvancar.Text = ">";
            this.buttonAvancar.UseVisualStyleBackColor = true;
            this.buttonAvancar.Click += new System.EventHandler(this.buttonAvancar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 429);
            this.Controls.Add(this.buttonAvancar);
            this.Controls.Add(this.buttonVoltar);
            this.Controls.Add(this.textUrl);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Browser);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser Browser;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textUrl;
        private System.Windows.Forms.Button buttonVoltar;
        private System.Windows.Forms.Button buttonAvancar;
    }
}

